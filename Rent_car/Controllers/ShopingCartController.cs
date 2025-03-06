using Microsoft.AspNetCore.Mvc;
using Rent_car.BL;
using Rent_car.Models;

namespace Rent_car.Controllers
{
    public class ShopingCartController : Controller
    {
        ICar oclsCar;
        public ShopingCartController(ICar car)
        {
            oclsCar = car;
        }
        public IActionResult Buy(int id)
        {
            TbCar car=new TbCar();
            car=oclsCar.GetCarById(id);
            return View(car);
        }
    }
}
