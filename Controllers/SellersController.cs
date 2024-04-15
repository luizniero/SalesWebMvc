using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SalesWebMvcContext _context;
        private readonly SellerServices _services;


        public SellersController(SellerServices service)
        {
            //_context = context;
            _services = service;
        }

        // GET: Sellers
        public async Task<IActionResult> Index()
        {
            return View(_services.FindAll());
        }


        // GET: Sellers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sellers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Seller seller)
        {
            if (ModelState.IsValid)
            {
                _services.Insert(seller);
                return RedirectToAction(nameof(Index));
            }
            return View(seller);
        }
    }
}
