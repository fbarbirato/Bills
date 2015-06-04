using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills.Application.DTOs
{
    public class AddNewBillRequest
    {
        public int BillYear { get; set; }
        
        public int BillMonth { get; set; }
        
        public string BillName { get; set; }
        
        public decimal BillValue { get; set; }
        
        public DateTime BillDueDate { get; set; }
    }
}
