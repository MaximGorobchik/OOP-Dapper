using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_16.Model
{
    public class Promotionalproducts
    {
        public int ShareID { get; set; }
        public string ProductName { get; set; }
        public int SectionID { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
