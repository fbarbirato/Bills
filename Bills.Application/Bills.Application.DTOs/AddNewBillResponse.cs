using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills.Application.DTOs
{
    public class AddNewBillResponse : Response
    {
        public int BillId { get; set; }

        public string BillName { get; set; }

        public DateTime BillDueDate { get; set; }
    }
}
