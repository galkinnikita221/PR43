using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EmployeesContext_Galkin.Classes
{
    public class Connection
    {
        private static readonly string config = "server=student.permaviat.ru;Trusted_Connection=No;TrustServerCertificate=True;DataBase=base2_ISP_21_2_2;User=ISP_21_2_2;pwd=7N1aGL8up#";

        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(config);
            connection.Open();
            return connection;
        }

        public static SqlDataReader Query(string SQL, out SqlConnection connection)
        {
            connection = OpenConnection();
            return new SqlCommand(SQL, connection).ExecuteReader();
        }
        public static void CloseConnection(SqlConnection connection)
        {
            connection.Close();
            SqlConnection.ClearPool(connection);
        }
    }
}
