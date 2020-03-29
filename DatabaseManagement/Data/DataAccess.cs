using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DatabaseManagement.Data.Models;
using Dapper;

namespace DatabaseManagement.Data
{
    public class DataAccess
    {
        public static string ConnectionString { get; set; }

        public bool Connect(string connectionString)
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    ConnectionString = connectionString;
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void AddPerson()
        {

        }

        public List<string> GetCitiesByCountry(string _country)
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                return con.Query<string>("dbo.cities_GetCitiesByCountry @country", new { country = _country }).ToList();
            }
        }

        public List<string> GetCountries()
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                return con.Query<string>("dbo.cities_GetCountries").ToList();
            }
        }

    }
}
