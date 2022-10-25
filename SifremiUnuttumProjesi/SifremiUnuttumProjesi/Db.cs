using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Db
{
    class DbConnection
    {
      public SqlConnection Connect()
        {
            string connectionString = "Data Source=LAPTOP-J8829534\\SQLEXPRESS;Initial Catalog=ntp_proje;Integrated Security=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            return cnn;
        }
    }
}
