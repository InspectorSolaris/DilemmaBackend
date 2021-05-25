using Dilemma.Common.Dtos;
using Dilemma.DAL.Context;
using Dilemma.DAL.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dilemma.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DilemmaController : ControllerBase
    {
        private readonly DilemmaDbContext _context;

        private readonly IMemoryCache _cache;

        private readonly IConfiguration _configuration;

        private readonly IWebHostEnvironment _webHostEnvironment;

        public DilemmaController(
            DilemmaDbContext context,
            IMemoryCache cache,
            IConfiguration configuration,
            IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _cache = cache;
            _configuration = configuration;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("test")]
        public async Task<IActionResult> Test()
        {
            var dilemmas = _context.Dilemmas
                .Select(x => new DilemmaDto()
                {
                    Id = x.Id,
                    Text = x.Text
                })
                .ToListAsync();

            var solutions = _context.Solutions
                .Select(x => new SolutionDto()
                {
                    Id = x.Id,
                    DilemmaId = x.DilemmaId,
                    Text = x.Text,
                    Rate = x.Rate
                })
                .ToListAsync();

            return new JsonResult(new TestDto()
            {
                Dilemmas = await dilemmas,
                Solutions = await solutions
            });
        }

        [HttpGet("statistics")]
        public async Task<IActionResult> Statistics()
        {
            return new JsonResult(await _cache.GetOrCreateAsync(nameof(Statistics), async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = new TimeSpan(
                    int.Parse(_configuration["Statistics:ExpirationHours"]),
                    int.Parse(_configuration["Statistics:ExpirationMinutes"]),
                    int.Parse(_configuration["Statistics:ExpirationSeconds"]));

                var sum = _context.Answers.SumAsync(x => x.Solution.Rate);
                var count = _context.Answers.CountAsync();

                return new StatisticsDto()
                {
                    Date = DateTimeOffset.UtcNow,
                    Rate = await sum / await count
                };
            }));
        }

        [HttpPost("answers")]
        public async Task<IActionResult> Answers([FromBody] IEnumerable<Guid> solutionsIds)
        {
            var unprocessedIds = new List<Guid>();

            foreach (var id in solutionsIds)
            {
                if (await _context.Solutions.AnyAsync(x => x.Id == id))
                {
                    await _context.AddAsync(new Answer()
                    {
                        Id = Guid.NewGuid(),
                        SolutionId = id,
                        CreationDate = DateTimeOffset.UtcNow
                    });
                }
                else
                {
                    unprocessedIds.Add(id);
                }

                await _context.SaveChangesAsync();
            }

            return new JsonResult(unprocessedIds);
        }

        [HttpGet("solution-image/{id}")]
        public async Task<IActionResult> SolutionImage([FromQuery] Guid solutionId)
        {
            var solution = await _context.Solutions.FirstOrDefaultAsync(x => x.Id == solutionId);

            if (solution == null)
            {
                return NotFound();
            }

            var path = $"{_webHostEnvironment.WebRootPath}\\{_configuration["Path:Images"]}\\{solution.Image}";
            var stream = System.IO.File.OpenRead(path);

            return File(stream, "image/jpeg");
        }
    }
}
