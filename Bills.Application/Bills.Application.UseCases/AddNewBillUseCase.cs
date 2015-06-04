using Bills.Application.DataGateways;
using Bills.Application.DTOs;
using Bills.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills.Application.UseCases
{
    public class AddNewBillUseCase
    {
        private IBillDataGateway _billRepository;

        public AddNewBillUseCase(IBillDataGateway billRepository)
        {
            _billRepository = billRepository;
        }

        public AddNewBillResponse Execute(AddNewBillRequest request)
        {

            //1) Validate Request
            
            //2) Create Bill Object	
            var bill = new Bill
            {
                Year = request.BillYear,
                Month = request.BillMonth,
                Name = request.BillName,
                Value = request.BillValue,
                DueDate = request.BillDueDate
            };

            //3) Store Bill Object
            _billRepository.AddNew(bill);

            //4) Create Response
            var response = new AddNewBillResponse
            {
                Success = true,
                Message = "Bill Added!",
                BillId = bill.Id,
                BillName = bill.Name,
                BillDueDate = bill.DueDate
            };

            //5) Return Response
            return response;
        }
    }
}
