using Dilemma.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Dilemma.DAL.Context
{
    public class DilemmaDbContext : DbContext
    {
        public DilemmaDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedData();
        }

        public DbSet<Models.Dilemma> Dilemmas { get; set; }

        public DbSet<Solution> Solutions { get; set; }

        public DbSet<Answer> Answers { get; set; }

        public DbSet<Statistics> Statistics { get; set; }
    }
}
