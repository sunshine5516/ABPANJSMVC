using Abp.AutoMapper;
using ABPARJS.Sessions.Dto;

namespace ABPARJS.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}