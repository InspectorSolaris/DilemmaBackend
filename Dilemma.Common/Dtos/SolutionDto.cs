using System;

namespace Dilemma.Common.Dtos
{
    public class SolutionDto
    {
        public Guid Id { get; set; }

        public Guid DilemmaId { get; set; }

        public string Text { get; set; }

        public double Rate { get; set; }
    }
}
