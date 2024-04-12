using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

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
    }
}
