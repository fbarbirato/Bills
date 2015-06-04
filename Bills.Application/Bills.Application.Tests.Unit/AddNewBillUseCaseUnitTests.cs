using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bills.Application.UseCases;
using Bills.Application.DTOs;
using FluentAssertions;
using Bills.Application.Repository;
using Moq;
using Bills.Application.DataGateways;
using Bills.Application.Entities;

namespace Bills.Application.Tests.Unit
{
    [TestClass]
    public class AddNewBillUseCaseUnitTests
    {
        private Mock<IBillDataGateway> _mockBillRepository;
        private AddNewBillUseCase _addNewBillUseCase;
        private AddNewBillRequest _request;

        [TestInitialize]
        public void Initialize()
        {

            _mockBillRepository = new Mock<IBillDataGateway>();

            _addNewBillUseCase = new AddNewBillUseCase(_mockBillRepository.Object);

            _request = new AddNewBillRequest
            {
                BillYear = 2015,
                BillMonth = 06,
                BillName = "Aluguel + condomínio",
                BillValue = 2000,
                BillDueDate = new DateTime(2015, 06, 05)
            };

        }

        [TestMethod]
        public void Execute_ValidNewBill_ShouldReturnSuccessResponse()
        {
            // arrange
            
            // act
            var response = _addNewBillUseCase.Execute(_request);

            // assert
            response.Success.Should().BeTrue();
        }

        [TestMethod]
        public void Execute_ValidNewBill_ShouldReturnCorrectResponseValues()
        {
            // arrange

            // act
            var response = _addNewBillUseCase.Execute(_request);

            // assert
            response.BillName.Should().Be(_request.BillName);
            response.BillDueDate.Should().Be(_request.BillDueDate);
        }

        [TestMethod]
        public void Execute_ValidNewBill_ShouldAddBillToRepository()
        {
            // arrange

            // act
            _addNewBillUseCase.Execute(_request);

            // assert
            _mockBillRepository.Verify(m => m.AddNew(It.IsAny<Bill>()), Times.Once());
        }
    }
}
