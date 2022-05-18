using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Medicine
    {
        public string? Name { get; set; }
        public int ExpirationDate { get; set; }
        public DateTime ProductionDate { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
    }
}
