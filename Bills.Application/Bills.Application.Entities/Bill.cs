using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills.Application.Entities
{
    public class Bill
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime DueDate { get; set; }
        public bool Paid { get; set; }
    }
}
