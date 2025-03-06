using Microsoft.AspNetCore.Mvc;
using Rent_car.BL;
using Rent_car.Models;
using System.Diagnostics;

namespace Rent_car.Controllers
{
    public class HomeController : Controller
    {
        ICar oClsCar;
        public HomeController(ICar car)
        {
           oClsCar = car;
        }

        public IActionResult Index()
        {
           List<TbCar> vm = new List<TbCar>();
            vm = oClsCar.GetCars();
            return View(vm);
        }

   
    }
}
