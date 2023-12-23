using System.Threading.Tasks;
using Abp.Application.Services;
using BMS.Authorization.Accounts.Dto;

namespace BMS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
