using WebApplication4.Models;

namespace WebApplication4.Services
{
	public interface ICustomerService
	{
		Task<Customer> GetById(int id);
	}
}
