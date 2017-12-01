using System.Threading.Tasks;
using Abp.Application.Services;
using ABPARJS.Configuration.Dto;

namespace ABPARJS.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}