using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class CommonDB
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = OrderDB; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public CommonDB(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException(nameof(connectionString));
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                }
            }
            catch (ArgumentException) { throw; }
            catch (InvalidOperationException) { throw; }
            catch (SqlException) { throw; }

            this.connectionString = connectionString;
        }

        protected DataSet ExecuteQuery(string q)
        {
            DataSet ds = new DataSet();

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlDataAdapter dap = new SqlDataAdapter(q, con))
            {
                dap.Fill(ds);
            }

            return ds;
        }

        protected void ExecuteNonQuery(string q)
        {
            try
            {
                string query = "INSERT INTO Renters (Name,PhoneNumber,PhysAddress,RegisterDate)" +
                    $"VALUES('{Name}','{PhoneNumber}','{PhysAddress}','{RegisterDate})";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (ObjectDisposedException) { throw; }
            catch (InvalidOperationException) { throw; }
            catch (InvalidCastException) { throw; }
            catch (SqlException) { throw; }
            catch (System.IO.IOException) { throw; }
        }
    }
}
