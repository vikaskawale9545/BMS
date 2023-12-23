using System.Threading.Tasks;
using Abp.Application.Services;
using BMS.Sessions.Dto;

namespace BMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
