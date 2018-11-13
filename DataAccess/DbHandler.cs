using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    public class DbHandler
    {
        public DbHandler(string connectionString)
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
        }

        public Rentee GetRentee(int id)
        {
            return null;
        }

        public Order GetOrder(int id)
        {
            return null;
        }

        public Bike GetBike(int id)
        {
            return null;
        }

        public bool NewRentee(Rentee rentee)
        {
            return false;
        }

        public bool NewOrder(Order order)
        {
            return false;
        }

        public bool NewBike(Bike bike)
        {
            return false;
        }

        public bool UpdateRentee(Rentee rentee)
        {
            return false;
        }

        public bool UpdateOrder(Order order)
        {
            return false;
        }

        public bool UpdateBike(Bike bike)
        {
            return false;
        }
    }
}
