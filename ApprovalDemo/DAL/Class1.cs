using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CustomerRepository
    {
        public static DataTable GetAllCustomers()
        {
            using (var connection = new SqlConnection("Server=localhost;Database=TSQLv4;Trusted_Connection=true;"))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM sales.customers ", connection))
                {
                    var da = new SqlDataAdapter(command);
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
