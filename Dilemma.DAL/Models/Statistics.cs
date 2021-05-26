using System;

namespace Dilemma.DAL.Models
{
    public class Statistics
    {
        public Guid Id { get; set; }

        public DateTimeOffset Date { get; set; }

        public double Rate { get; set; }
    }
}
