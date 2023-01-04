using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using OOP_16.Repository.Покупці;
using OOP_16.Model;
using OOP_16.Repository.Розділи_Товарів;
using OOP_16.Repository.Акційні_товари;
using OOP_16.Repository.Країни;
using OOP_16.Repository.Міста;
using OOP_16.Repository.Акції_Країни;

namespace OOP_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FSB\MYSERVER;Initial Catalog=SpisokRozsilky;Integrated Security=True;");
            BuyersRepos buyersRepos = new BuyersRepos(con);
            SectionsofGoodsRepos sectionsofGoodsRepos = new SectionsofGoodsRepos(con);
            PromotionalproductsRepos promotionalproductsRepos = new PromotionalproductsRepos(con);
            CountryRepos countryRepos = new CountryRepos(con);
            TownRepos townRepos = new TownRepos(con);
            SharesofthecountryRepos sharesofthecountryRepos = new SharesofthecountryRepos(con);
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
                Console.WriteLine("1.Вiдображення всiх покупцiв");
                Console.WriteLine("2.Вiдображення email всiх покупцiв");
                Console.WriteLine("3.Вiдображення списку роздiлiв");
                Console.WriteLine("4.Вiдображення списку акцiйних товарiв");
                Console.WriteLine("5.Вiдображення всiх країн");
                Console.WriteLine("6.Вiдображення всiх мiст");
                Console.WriteLine("7.Вiдображення всiх покупцiв iз конкретного мiста");
                Console.WriteLine("8.Вiдображення всiх покупцiв iз конкретної країни");
                Console.WriteLine("9.Вiдображення всiх акцiй для конкретної країни");
                while (true)
                {
                    int n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            buyersRepos.ShowAllBuyers();
                            break;
                        case 2:
                            buyersRepos.ShowAllBuyersEmail();
                            break;
                        case 3:
                            sectionsofGoodsRepos.ShowGoodsRepos();
                            break;
                        case 4:
                            promotionalproductsRepos.ShowAllPromotionalProducts();
                            break;
                        case 5:
                            countryRepos.ShowAllCountry();
                            break;
                        case 6:
                            townRepos.ShowAllTown();
                            break;
                        case 7:
                            buyersRepos.ShowAllBuyersfromTown();
                            break;
                        case 8:
                            buyersRepos.ShowAllBuyersfromCountry();
                            break;
                        case 9:
                            sharesofthecountryRepos.ShowAllSharesofCountry();
                            break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
