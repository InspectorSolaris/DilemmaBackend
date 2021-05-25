using Dilemma.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Dilemma.DAL.Context
{
    public class DilemmaDbContext : DbContext
    {
        public DbSet<Models.Dilemma> Dilemmas { get; set; }

        public DbSet<Solution> Solutions { get; set; }

        public DbSet<Answer> Answers { get; set; }
    }
}
