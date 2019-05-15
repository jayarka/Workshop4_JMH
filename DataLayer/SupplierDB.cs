using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public static class SupplierDB
    {
        public static Supplier GetSupplier(int ID)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            Supplier s = new Supplier();
            try
            {

                string sql = "SELECT SupplierID FROM Suppliers WHERE SupplierID = " + ID;
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())

                {
                    s.SupplierID = Convert.ToInt32(reader["SupplierID"]);
                    s.SupName = reader["SupName"].ToString();
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }


            return s;
        }

        public static void AddSupplier(string supName)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            try
            {

                string sql = "INSERT INTO Suppliers (SupName) VALUES (@SupName)";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@SupName", supName);

                command.ExecuteNonQuery();


            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
        }
    }
}
