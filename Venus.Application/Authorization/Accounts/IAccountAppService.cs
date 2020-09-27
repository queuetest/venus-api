using System.Threading.Tasks;
using Abp.Application.Services;
using Venus.Authorization.Accounts.Dto;

namespace Venus.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
