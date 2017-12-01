using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPARJS.Configuration.Dto;

namespace ABPARJS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPARJSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
