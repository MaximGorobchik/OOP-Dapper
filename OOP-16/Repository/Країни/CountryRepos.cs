using OOP_16.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace OOP_16.Repository.Країни
{
    public class CountryRepos
    {
        private static SqlConnection con;
        public CountryRepos(SqlConnection connection)
        {
            con = connection;
        }
        private IEnumerable<Country> CountryModel()
        {
            var get = con.Query<Country>("Select * from Країни");
            return get;
        }
        public void ShowAllCountry()
        {
            foreach (Country item in CountryModel())
            {
                Console.WriteLine($"{item.ID} {item.Name}");
            }
        }
    }
}
