using System.Security.Cryptography.Xml;
using Castle.Core.Resource;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using WebApplication4.Controllers;
using WebApplication4.Models;
using WebApplication4.Services;

namespace WebApplication4.UnitTest
{
	public class CustomersControllerTests
	{
		private readonly DemoContext _context;
		private readonly CustomersController _controller;

		public CustomersControllerTests() 
		{ 
			var options = new DbContextOptionsBuilder<DemoContext>()
								.UseInMemoryDatabase(Guid.NewGuid().ToString())
								.Options;
			_context = new DemoContext(options);

			_controller = new CustomersController(_context);
		}

		[Fact]
		public async Task Index_should_return_list_of_customers()
		{
			// Arrange
			_context.Customer.Add(new Customer { Id = 1, Name = "Maali Maasikas" });
			_context.SaveChanges();

			// Act
			var result = await _controller.Index() as ViewResult;

			// Assert
			Assert.NotNull(result);
			var isCorrectView = result.ViewName == null ||
								result.ViewName == "Index";
			Assert.True(isCorrectView);
			var model = result.Model as IEnumerable<Customer>;
			Assert.NotNull(model);
			Assert.Single(model);
		}

		[Fact]
		public async Task Details_should_return_notfound_when_id_is_null()
		{
            // Arrange
            _context.Customer.Add(new Customer { Id = 1, Name = "Maali Maasikas" });
            _context.SaveChanges();

            // Act
            var result = await _controller.Details(null) as NotFoundResult;

			// Assert
			Assert.NotNull(result);
		}


     


    }
}