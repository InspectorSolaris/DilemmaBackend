using Dilemma.Common.Dtos;
using Dilemma.Common.Interfaces;
using Dilemma.DAL.Context;
using Dilemma.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dilemma.BL.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly DilemmaDbContext _context;

        private readonly IMemoryCache _cache;

        private readonly IConfiguration _configuration;

        public StatisticsService(
            DilemmaDbContext context,
            IMemoryCache cache,
            IConfiguration configuration)
        {
            _context = context;
            _cache = cache;
            _configuration = configuration;
        }

        public async Task Update()
        {
            var statisticsDeltaHours = int.Parse(_configuration["Statistics:StepHours"]);
            var statistics = _context.Statistics
                .OrderByDescending(x => x.Date)
                .FirstOrDefault();

            if (statistics == null)
            {
                var firstAnswer = _context.Answers
                    .OrderByDescending(x => x.Date)
                    .FirstOrDefault();

                if (firstAnswer == null)
                {
                    return;
                }

                var statisticsDateTime = firstAnswer.Date
                    .AddMinutes(-firstAnswer.Date.Minute)
                    .AddSeconds(-firstAnswer.Date.Second)
                    .AddMilliseconds(-firstAnswer.Date.Millisecond);

                statistics = new Statistics()
                {
                    Id = Guid.NewGuid(),
                    Date = statisticsDateTime
                };

                await _context.AddAsync(statistics);
            }

            var answers = _context.Answers
                .Where(x => statistics.Date <= x.Date)
                .Include(x => x.Solution)
                .OrderBy(x => x.Date);

            var start = new DateTimeOffset(statistics.Date.DateTime, statistics.Date.Offset);
            var minDateTime = start
                .AddMinutes(-start.Minute)
                .AddSeconds(-start.Second)
                .AddMilliseconds(-start.Millisecond);
            var maxDateTime = minDateTime.AddHours(statisticsDeltaHours);

            statistics.Rate = await CalculateAnswersMeanRate(answers, minDateTime, maxDateTime);

            minDateTime = minDateTime.AddHours(statisticsDeltaHours);
            maxDateTime = maxDateTime.AddHours(statisticsDeltaHours);

            while (maxDateTime <= DateTimeOffset.UtcNow)
            {
                var statisticsNew = new Statistics()
                {
                    Id = Guid.NewGuid(),
                    Date = minDateTime,
                    Rate = await CalculateAnswersMeanRate(answers, minDateTime, maxDateTime)
                };

                await _context.AddAsync(statisticsNew);

                minDateTime = minDateTime.AddHours(statisticsDeltaHours);
                maxDateTime = maxDateTime.AddHours(statisticsDeltaHours);
            }

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<StatisticsDto>> Get()
        {
            await Update();

            var ans = await _context.Statistics
                .Select(x => new StatisticsDto()
                {
                    Date = x.Date,
                    Rate = x.Rate
                })
                .ToListAsync();

            return ans;
        }

        private async Task<double> CalculateAnswersMeanRate(IQueryable<Answer> answers, DateTimeOffset minDate, DateTimeOffset maxDate)
        {
            var query = answers.Where(x => minDate <= x.Date && x.Date <= maxDate);

            var sum = await query.SumAsync(x => x.Solution.Rate);
            var count = await query.CountAsync();

            return sum / count;
        }
    }
}
