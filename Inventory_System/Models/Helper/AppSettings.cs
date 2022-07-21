using EncryptString;
using System.Configuration;

namespace Inventory_System.Model
{
    public class AppSettings : IAppSettings
    {
        private Configuration config;

        public AppSettings()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }


        public string GetConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }

        public void SaveConnectionString(string key, string value)
        {
            StringEncryptor StrCrypt = new StringEncryptor();
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = StrCrypt.Encrypt(value);
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Date.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
