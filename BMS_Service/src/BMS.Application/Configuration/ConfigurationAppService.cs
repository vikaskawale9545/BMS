using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using BMS.Configuration.Dto;

namespace BMS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BMSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
