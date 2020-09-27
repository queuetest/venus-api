using System.Threading.Tasks;
using Abp.Application.Services;
using Venus.Sessions.Dto;

namespace Venus.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
