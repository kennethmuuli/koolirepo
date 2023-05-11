using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Services
{
	public class CustomerService : ICustomerService
	{
		private readonly DemoContext _context;

		public CustomerService(DemoContext context)
		{
			_context = context;
		}

		public async Task<Customer> GetById(int id)
		{
			return await _context.Customer
								 .Where(c => c.Id == id)
								 .FirstOrDefaultAsync();
		}
	}
}
