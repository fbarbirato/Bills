using Bills.Application.DataGateways;
using Bills.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills.Application.Repository
{
    public class BillRepository : IBillDataGateway
    {
        public void AddNew(Bill bill)
        {
            throw new NotImplementedException();
        }
        
        public void Save(Bill bill)
        {
            throw new NotImplementedException();
        }

        public Bill FindBy(int id)
        {
            throw new NotImplementedException();
        }
                
    }
}
