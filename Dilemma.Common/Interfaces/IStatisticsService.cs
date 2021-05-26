using Dilemma.Common.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dilemma.Common.Interfaces
{
    public interface IStatisticsService
    {
        Task Update();

        Task<IEnumerable<StatisticsDto>> Get();
    }
}
