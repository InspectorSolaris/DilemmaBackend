using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dilemma.Common.Interfaces
{
    public interface IAnswerService
    {
        Task<IEnumerable<Guid>> ProcessNewAnswersAsync(IEnumerable<Guid> solutionsIds);
    }
}
