using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_16.Model
{
    public class buyers
    {
        public int ID { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Datebirth { get; set; }
        public int CountryID { get; set; }
        public int TownID { get; set; }
    }
}
