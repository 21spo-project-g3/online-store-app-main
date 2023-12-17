using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using online_store_app.Data;
using online_store_app.Models;
using online_store_app.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace online_store_app.Controllers
{
    [Authorize(Policy = "AdminOnly")] // Ensure only admins can access this controller
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            var viewModel = new DashboardViewModel
            {
                Products = _context.Products.ToList() ?? new List<Product>(), // Use ?? to provide an empty list if the result is null
                Categories = _context.Categories.ToList() ?? new List<Category>()
            };

            return View("~/Views/Admin/Dashboard.cshtml", viewModel);
        }

        // GET: Dashboard/Create
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_context.Categories.OrderBy(c => c.DisplayOrder), "Id", "Name");
            return View("~/Views/Admin/Dashboard/Create.cshtml");
        }

        // POST: Dashboard/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction("Dashboard"); // Redirect to the Dashboard action
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            return View(product);
        }

        // GET: Dashboard/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.Categories = new SelectList(_context.Categories.OrderBy(c => c.DisplayOrder), "Id", "Name");
            return View("~/Views/Admin/Dashboard/Edit.cshtml", product); // Correct path
        }

        // POST: Dashboard/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id", "EAN", "Name", "Description", "Price", "ImageUrl", "Quantity", "IsOnSale", "SalePercentage", "CategoryId")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Dashboard");
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            return View("~/Views/Admin/Dashboard/Edit.cshtml", product); // Correct path
        }

        // GET: Dashboard/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View("~/Views/Admin/Dashboard/Delete.cshtml", product); // Correct path
        }

        // POST: Dashboard/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Dashboard");
        }

        // Check if a product exists
        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}