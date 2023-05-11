using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
	public class CustomersServiceController : Controller
	{
		private readonly DemoContext _context;
		private readonly ICustomerService _customerService;

		public CustomersServiceController(DemoContext context, ICustomerService customerService)
		{
			_context = context;
			_customerService = customerService;
		}

		// GET: Customers
		public async Task<IActionResult> Index()
		{
			return View(await _context.Customer.ToListAsync());
		}

		// GET: Customers/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var customer = await _customerService.GetById(id.Value);
			if (customer == null)
			{
				return NotFound();
			}

			return View(customer);
		}

		// GET: Customers/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Customers/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Name,Email,Address,Phone")] Customer customer)
		{
			if (ModelState.IsValid)
			{
				_context.Add(customer);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(customer);
		}

		// GET: Customers/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null || _context.Customer == null)
			{
				return NotFound();
			}

			var customer = await _context.Customer.FindAsync(id);
			if (customer == null)
			{
				return NotFound();
			}
			return View(customer);
		}

		// POST: Customers/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Address,Phone")] Customer customer)
		{
			if (id != customer.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(customer);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!CustomerExists(customer.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(customer);
		}

		// GET: Customers/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null || _context.Customer == null)
			{
				return NotFound();
			}

			var customer = await _context.Customer
				.FirstOrDefaultAsync(m => m.Id == id);
			if (customer == null)
			{
				return NotFound();
			}

			return View(customer);
		}

		// POST: Customers/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			if (_context.Customer == null)
			{
				return Problem("Entity set 'DemoContext.Customer'  is null.");
			}
			var customer = await _context.Customer.FindAsync(id);
			if (customer != null)
			{
				_context.Customer.Remove(customer);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool CustomerExists(int id)
		{
			return _context.Customer.Any(e => e.Id == id);
		}

		[HttpGet]
		public async Task<IActionResult> UploadFile()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> UploadFile(IFormFile file)
		{
			// Kontrolli faili kohta
			if (file == null)
			{
				throw new ArgumentNullException(nameof(file));
			}
			// Veel mingeid kontrolle

			using (var fileStream = new FileStream("c:\\temp\\file.txt", FileMode.OpenOrCreate))
			using (var uploadedStream = file.OpenReadStream())
			{
				uploadedStream.Seek(0, SeekOrigin.Begin);
				uploadedStream.CopyTo(fileStream);
			}

			return RedirectToAction("Index");
		}
	}
}
