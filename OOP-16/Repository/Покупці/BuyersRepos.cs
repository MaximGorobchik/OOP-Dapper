using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using OOP_16.Model;
using System.Data;

namespace OOP_16.Repository.Покупці
{
    public class BuyersRepos
    {
        private static SqlConnection con;
        public BuyersRepos(SqlConnection connection) 
        { 
            con = connection;
        }
        private IEnumerable<buyers> BuyersModel()
        {
            var get = con.Query<buyers>("ShowAllBuyers", commandType: CommandType.StoredProcedure);
            return get;
        }
        public void ShowAllBuyers()
        {
            foreach(buyers item in BuyersModel())
            {
                Console.WriteLine($"{item.ID} {item.Lastname} {item.Firstname} {item.Surname} {item.Email} {item.Datebirth} {item.CountryID} {item.TownID}");
            }
        }
        public void ShowAllBuyersEmail()
        {
            var get = con.Query<buyers>("Select Email from Покупці");
            foreach (buyers item in BuyersModel())
            {
                Console.WriteLine($"{item.Email}");
            }
        }
        public void ShowAllBuyersfromTown()
        {
            Console.WriteLine("Введiть містоID: ");
            int townid = int.Parse(Console.ReadLine());
            DynamicParameters param = new DynamicParameters();
            param.Add("@townid", townid);
            var get = con.Query<buyers>("ShowBuyersofTown", param, commandType:CommandType.StoredProcedure);
            foreach (buyers item in get)
            {
                Console.WriteLine($"{item.ID} {item.Lastname} {item.Firstname} {item.Surname} {item.Email} {item.Datebirth} {item.CountryID} {item.TownID}");
            }
        }
        public void ShowAllBuyersfromCountry()
        {
            Console.WriteLine("Введiть countryID: ");
            int country = int.Parse(Console.ReadLine());
            DynamicParameters param = new DynamicParameters();
            param.Add("@countryid", country);
            var get = con.Query<buyers>("ShowBuyersofCountry", param, commandType: CommandType.StoredProcedure);
            foreach (buyers item in get)
            {
                Console.WriteLine($"{item.ID} {item.Lastname} {item.Firstname} {item.Surname} {item.Email} {item.Datebirth} {item.CountryID} {item.TownID}");
            }
        }
    }
}
