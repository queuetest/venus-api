using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Venus.Configuration.Dto;

namespace Venus.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : VenusAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
