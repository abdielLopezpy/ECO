using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using appDash.Data;
using appDash.Models;

namespace appDash.Purchase
{
    public class PrivatePurchaseController : Controller
    {
        private readonly ApplicationDbContext _context;

public PrivatePurchaseController(ApplicationDbContext context)
{
    _context = context;
}



        // GET: Purchase/Create
        public IActionResult Create()
        {
    ViewBag.ProductId = new SelectList(_context.Products, "Id", "Name");
    ViewBag.ProductPrices = _context.Products.ToDictionary(p => p.Id, p => p.Price);
    return View();        }

        // POST: Purchase/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductId,Quantity,FullName,Email,Address,Phone")] appDash.Models.Purchase purchase)
        {
            if (ModelState.IsValid)
            {
                _context.Add(purchase);
                await _context.SaveChangesAsync();
        return RedirectToAction("Index", "Home");
            }
            return View(purchase);
        }

}
}