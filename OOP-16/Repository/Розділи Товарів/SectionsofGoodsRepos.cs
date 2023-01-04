using OOP_16.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace OOP_16.Repository.Розділи_Товарів
{
    public class SectionsofGoodsRepos
    {
        private static SqlConnection con;
        public SectionsofGoodsRepos(SqlConnection connection)
        {
            con = connection;
        }
        private IEnumerable<SectionsofGoods> GoodsModel()
        {
            var get = con.Query<SectionsofGoods>("Select * from [Розділи товарів]");
            return get;
        }
        public void ShowGoodsRepos()
        {
            foreach (SectionsofGoods item in GoodsModel())
            {
                Console.WriteLine($"{item.ID} {item.Name}");
            }
        }
    }
}
