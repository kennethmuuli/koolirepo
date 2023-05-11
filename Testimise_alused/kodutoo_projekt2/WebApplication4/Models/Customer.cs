using Microsoft.Build.Framework;

namespace WebApplication4.Models
{
	public class Customer
	{
        public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }

        //wallet table inc ref to customer
        //favorite table inc ref to customer
    }
}
