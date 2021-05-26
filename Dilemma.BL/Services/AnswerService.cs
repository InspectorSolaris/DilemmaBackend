using Dilemma.Common.Interfaces;
using Dilemma.DAL.Context;
using Dilemma.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dilemma.BL.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly DilemmaDbContext _context;

        public AnswerService(DilemmaDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Guid>> ProcessNewAnswersAsync(IEnumerable<Guid> solutionsIds)
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
                        Date = DateTimeOffset.UtcNow
                    });
                }
                else
                {
                    unprocessedIds.Add(id);
                }

                await _context.SaveChangesAsync();
            }

            return unprocessedIds;
        }
    }
}
