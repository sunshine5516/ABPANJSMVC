using System.Threading.Tasks;
using Abp.Application.Services;
using ABPARJS.Authorization.Accounts.Dto;

namespace ABPARJS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
