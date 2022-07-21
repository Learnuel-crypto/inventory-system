using System.Data.SqlClient;

namespace Inventory_System.Model
{
    public interface ISqlHelper
    {
        bool IsConnection { get; }

        void Close();
        SqlConnection GetConnection();
        void Open();
    }
}