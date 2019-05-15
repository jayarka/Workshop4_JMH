using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class TravelExpertsDB
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            string ConnectionString = "Data Source=softdev; Initial Catalog=TravelExperts; Integrated Security=true;";
            connection.ConnectionString = ConnectionString;
            connection.Open();

            return connection;
        }
    }
}
