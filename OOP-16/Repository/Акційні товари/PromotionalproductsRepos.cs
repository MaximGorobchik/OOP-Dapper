using OOP_16.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace OOP_16.Repository.Акційні_товари
{
    public class PromotionalproductsRepos
    {
        private static SqlConnection con;
        public PromotionalproductsRepos(SqlConnection connection)
        {
            con = connection;
        }
        private IEnumerable<Promotionalproducts> ProductsModel()
        {
            var get = con.Query<Promotionalproducts>("Select * from [Акційні товари]");
            return get;
        }
        public void ShowAllPromotionalProducts()
        {
            foreach (Promotionalproducts item in ProductsModel())
            {
                Console.WriteLine($"{item.ShareID} {item.ProductName} {item.SectionID} {item.DateStart} {item.DateStart}");
            }
        }
    }
}
