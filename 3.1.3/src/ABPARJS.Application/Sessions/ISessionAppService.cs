using System.Threading.Tasks;
using Abp.Application.Services;
using ABPARJS.Sessions.Dto;

namespace ABPARJS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
