using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixelia
{
    internal class Dataccess
    {
        static string strConn = "Data Source = (local);Initial Catalog = Pixelia; Integrated Security = SSPI";
        public static SqlConnection conn = new SqlConnection(strConn);


        public static SqlConnection getConnection()
        {
            return conn;
        }

        public static SqlCommand getCommand(string strComm)
        {
            SqlCommand comm = new SqlCommand(strComm, conn);
            return comm;
        }
    }
}

