using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using WebApplication4.Controllers;
using WebApplication4.Models;
using WebApplication4.Services;

namespace WebApplication4.UnitTest
{
	public class CustomersServiceControllerTests
	{
		private readonly CustomersServiceController _controller;
		private readonly Mock<ICustomerService> _customerServiceMock;

		public CustomersServiceControllerTests()
		{
			var options = new DbContextOptions<DemoContext>();
			var _context = new DemoContext(options);

			_customerServiceMock = new Mock<ICustomerService>();

			_controller = new CustomersServiceController(_context, _customerServiceMock.Object);
		}

		[Fact]
		public async Task Details_should_return_notfound_when_customer_is_not_found()
		{
			// Arrange
			//var customer = (Customer)null;
			var customer = GetMockCustomer();
			_customerServiceMock.Setup(x => x.GetById(1))
								.ReturnsAsync(customer);

			// Act
			var result = await _controller.Details(2) as NotFoundResult;

			// Arrange
			Assert.NotNull(result);
		}

        [Fact]
        public async Task Details_should_return_customer()
        {
            // Arrange
            //var customer = (Customer)null;
            var customer = GetMockCustomer();
            _customerServiceMock.Setup(x => x.GetById(1))
                                .ReturnsAsync(customer);

            // Act
            var result = await _controller.Details(1) as ViewResult;
            var model = result.Model as Customer;


            // Arrange
            Assert.NotNull(model);
			Assert.Equal(model.Id, customer.Id);
			// Karli tip, hea asi, mida kasutada, kontrollimaks mingi meetodi siseseid meetodite väljakutseid:
				// _customerServiceMock.Verify(mock => mock.GetById(1), Times.Never());
        }

        private Customer GetMockCustomer()
		{
			var customer = new Customer();
			customer.Id = 1;
			return customer;
		}
	}
}
