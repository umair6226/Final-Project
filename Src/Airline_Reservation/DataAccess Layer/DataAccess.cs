using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess_Layer
{
    public class DataAccess
    {
        static string connection = "Server=DESKTOP-8092C33;Database=Airline_Reservation_System;integrated security= true;";
        public static int ExecuteQuery(string query, SqlParameter[] prm)
        {
            //SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);

            SqlConnection conn = new SqlConnection(connection);
            int num = 0;
            SqlCommand sqlCommand = new SqlCommand()
            {
                Connection = conn,
                CommandType = CommandType.StoredProcedure,
                CommandText = query
            };
            sqlCommand.Parameters.AddRange(prm);
            conn.Open();
            num = sqlCommand.ExecuteNonQuery();
            conn.Close();
            return num;
        }

        public static DataTable GetDataTable(string query, SqlParameter[] prm)
        {

            SqlConnection conn = new SqlConnection(connection);
            SqlCommand sqlCommand = new SqlCommand()
            {
                Connection = conn,
                CommandType = CommandType.StoredProcedure,
                CommandText = query
            };
            sqlCommand.Parameters.AddRange(prm);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
