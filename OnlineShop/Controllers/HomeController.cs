using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineShop.Models;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IShoesOperation _shoesOperation;

        public HomeController(ILogger<HomeController> logger, IShoesOperation shoesOperation)
        {
            _logger = logger;
            _shoesOperation = shoesOperation;
        }

        public IActionResult Index()
        {
            ShoesListVM model = new ShoesListVM()
            {
                Shoes = _shoesOperation.GetAll()
            };
            return View(model);
        }

        public IActionResult ShoesDetails(int Id)
        {
            ShoesListVM model = new ShoesListVM()
            {
                OnePairShoes = _shoesOperation.GetShoesPair(Id)
            };

            return View(model);
        }

        public IActionResult Basket()
        {
            return View(BasketData.ShoesInBasket);
        }

        public IActionResult AddToBasket(int Id)
        {
            var OnePairShoes = _shoesOperation.GetShoesPair(Id);
            BasketData.ShoesInBasket.Add(OnePairShoes);

            var data = BasketData.ShoesInBasket;
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
