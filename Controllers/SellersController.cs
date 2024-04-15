using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;
using SalesWebMvc.Models;
using System.Threading.Tasks;
using System;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerServices _services;

        public SellersController(SellerServices services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
            var list = _services.FindAll();
            return View(list);
        }

        [HttpPost]
        public IActionResult Create(Seller seller)
        {
            Console.WriteLine("Tentando criar");
            //_services.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
