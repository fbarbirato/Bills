using Bills.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bills.Application.DataGateways
{
    public interface IBillDataGateway
    {
        void AddNew(Bill bill);
        
        void Save(Bill bill);

        Bill FindBy(int id);
    }
}
