using Dilemma.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Dilemma.DAL.Context
{
    public static class DilemmaDbContextSeed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            var dilemmas = new List<Models.Dilemma>()
            {
                new Models.Dilemma()
                {
                    Id = Guid.NewGuid(),
                    Text = "Dilemma 1"
                },
                new Models.Dilemma()
                {
                    Id = Guid.NewGuid(),
                    Text = "Dilemma 2"
                },
                new Models.Dilemma()
                {
                    Id = Guid.NewGuid(),
                    Text = "Dilemma 3"
                }
            };

            var solutions = new List<Solution>()
            {
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[0].Id,
                    Text = "Dilemma 1 Solution 1",
                    Image = "dilemma_1_solution_1.jpeg",
                    Rate = 0.7
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[0].Id,
                    Text = "Dilemma 1 Solution 2",
                    Image = "dilemma_1_solution_2.jpeg",
                    Rate = -0.4
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[1].Id,
                    Text = "Dilemma 2 Solution 1",
                    Image = "dilemma_1_solution_1.jpeg",
                    Rate = 0.4
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[1].Id,
                    Text = "Dilemma 2 Solution 2",
                    Image = "dilemma_1_solution_2.jpeg",
                    Rate = -0.5
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[2].Id,
                    Text = "Dilemma 3 Solution 1",
                    Image = "dilemma_1_solution_1.jpeg",
                    Rate = 0.6
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[2].Id,
                    Text = "Dilemma 3 Solution 2",
                    Image = "dilemma_1_solution_2.jpeg",
                    Rate = -0.2
                }
            };

            modelBuilder.Entity<Models.Dilemma>().HasData(dilemmas);
            modelBuilder.Entity<Solution>().HasData(solutions);
        }
    }
}
