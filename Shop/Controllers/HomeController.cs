using Shop.Data.interfaces;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        public readonly IAllCars _carRep;
    

        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;

        }
        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _carRep.getFavCars
            };
            return View(homeCars);
        }

    }
}
