using KBVault.Dal.Entities;

namespace KBVault.Web.Business.ApplicationSettings
{
    public interface ISettingsService
    {
        Settings GetSettings();
        void ReloadSettings();
    }
}
