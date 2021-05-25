using System.Collections.Generic;

namespace Dilemma.Common.Dtos
{
    public class TestDto
    {
        public IEnumerable<DilemmaDto> Dilemmas { get; set; }

        public IEnumerable<SolutionDto> Solutions { get; set; }
    }
}
