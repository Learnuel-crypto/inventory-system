namespace Inventory_System.Model
{
    public interface IAppSettings
    {
        string GetConnectionString(string key);
        void SaveConnectionString(string key, string value);
    }
}