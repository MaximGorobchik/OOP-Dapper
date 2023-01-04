using OOP_16.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace OOP_16.Repository.Міста
{
    public class TownRepos
    {
        private static SqlConnection con;
        public TownRepos(SqlConnection connection)
        {
            con = connection;
        }
        private IEnumerable<Town> TownModel()
        {
            var get = con.Query<Town>("Select * from Міста");
            return get;
        }
        public void ShowAllTown()
        {
            foreach (Town item in TownModel())
            {
                Console.WriteLine($"{item.ID} {item.Name} {item.CountryID}");
            }
        }
    }
}
