using System.Configuration;
using System.Data.SqlClient;

namespace WebHelper
{
    class DBHelper
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebDBConnectionString"].ToString());
        SqlCommand command;
        SqlDataReader dr;

    }
}
