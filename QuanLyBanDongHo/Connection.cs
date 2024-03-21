using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyBanDongHo
{
    public class Connection
    {
        private static string stringConnection = @"Data Source=.;Initial Catalog = QLBanDongHo; Integrated Security = True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
