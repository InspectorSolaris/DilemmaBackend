using System;

namespace Dilemma.DAL.Models
{
    public class Answer
    {
        public Guid Id { get; set; }

        public Guid SolutionId { get; set; }

        public Solution Solution { get; set; }

        public DateTimeOffset Date { get; set; }
    }
}
