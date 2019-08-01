using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WpfApp1
{
    public static class General
    {
        public static string myDBConn = "Server=DESKTOP-SNIFN8M;Database=TestDB;Trusted_Connection=True;";

        public static string Left(string param, int length)
        {
            string result = param.Substring(0, length);
            return result;
        }
        public static string Right(string param, int length)
        {
            string result = param.Substring(param.Length - length, length);
            return result;
        }

        public static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }

        public static int Instr(string str, string srch, int strtpos)
        {
            int rtn = -1;
            rtn = str.IndexOf(srch, strtpos);
            return rtn;
        }

        public static DataTable GetData(string getSQL)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(General.myDBConn);
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            command = new SqlCommand(getSQL, connection);
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            return dt;
        }








    }
}
