using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABPARJS.MultiTenancy.Dto;

namespace ABPARJS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
