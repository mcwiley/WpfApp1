// ***********************************************************************
// Assembly         : WpfApp1
// Author           : m_c_w
// Created          : 07-31-2019
//
// Last Modified By : m_c_w
// Last Modified On : 08-08-2019
// ***********************************************************************
// <copyright file="General.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WpfApp1
{
    /// <summary>
    /// Class General.
    /// </summary>
    public static class General
    {
        /// <summary>
        /// My database connection
        /// </summary>
        public static string myDBTEST = "Server=DESKTOP-SNIFN8M;Database=TestDB;Trusted_Connection=True;";
        public static string DBNorth = "Server=DESKTOP-SNIFN8M;Database=Northwind;Trusted_Connection=True;";

        /// <summary>
        /// Lefts the specified parameter.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <param name="length">The length.</param>
        /// <returns>System.String.</returns>
        public static string Left(string param, int length)
        {
            string result = param.Substring(0, length);
            return result;
        }
        /// <summary>
        /// Rights the specified parameter.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <param name="length">The length.</param>
        /// <returns>System.String.</returns>
        public static string Right(string param, int length)
        {
            string result = param.Substring(param.Length - length, length);
            return result;
        }

        /// <summary>
        /// Mids the specified parameter.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <param name="startIndex">The start index.</param>
        /// <param name="length">The length.</param>
        /// <returns>System.String.</returns>
        public static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }

        /// <summary>
        /// Instrs the specified string.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="srch">The SRCH.</param>
        /// <param name="strtpos">The strtpos.</param>
        /// <returns>System.Int32.</returns>
        public static int Instr(string str, string srch, int strtpos)
        {
            int rtn = -1;
            rtn = str.IndexOf(srch, strtpos);
            return rtn;
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <param name="getSQL">The get SQL.</param>
        /// <returns>DataTable.</returns>
        public static DataTable GetDataTEST(string getSQL)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(General.myDBTEST);
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            command = new SqlCommand(getSQL, connection);
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            return dt;
        }








    }
}
