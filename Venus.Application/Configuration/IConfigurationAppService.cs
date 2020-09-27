using System.Threading.Tasks;
using Venus.Configuration.Dto;

namespace Venus.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
