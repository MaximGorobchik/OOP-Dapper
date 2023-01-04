using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using OOP_16.Model;

namespace OOP_16.Repository.Акції_Країни
{
    public class SharesofthecountryRepos
    {
        private static SqlConnection con;
        public SharesofthecountryRepos(SqlConnection connection)
        {
            con = connection;
        }
        public void ShowAllSharesofCountry()
        {
            Console.WriteLine("Введiть countryID: ");
            int country = int.Parse(Console.ReadLine());
            DynamicParameters param = new DynamicParameters();
            param.Add("@countryid", country);
            var get = con.Query<SharesOfTheCountry>("ShowSharesofCountry", param, commandType:System.Data.CommandType.StoredProcedure);
            foreach (SharesOfTheCountry item in get)
            {
                Console.WriteLine($"{item.ShareID}");
            }
        }
    }
}
