using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOT_BFMS
{
    internal class SQLConnect
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BFMS;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"
            );
        }
    }
}
