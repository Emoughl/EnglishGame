using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Test
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=LAPTOP-2S0CP2JK\SQLEXPRESS01;Initial Catalog=EnglishQG;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
