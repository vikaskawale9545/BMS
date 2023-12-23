using System.Threading.Tasks;
using BMS.Configuration.Dto;

namespace BMS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
