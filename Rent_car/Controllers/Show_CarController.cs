using Microsoft.AspNetCore.Mvc;
using Rent_car.BL;
using Rent_car.Models;

namespace Rent_car.Controllers
{
    public class Show_CarController : Controller
    {
        ICar oclsCar;
        public Show_CarController(ICar car)
        {
            oclsCar = car;
        }
        public IActionResult Main(int Id)
        {
            VmCar vm = new VmCar();

            vm.CarDetails = oclsCar.GetCarById(Id);
            vm.RecommendedCar = oclsCar.GetRecommendedCars(Id).Take(12).ToList();
            return View(vm);
        }
    public IActionResult Result(string name)
    {
      List<TbCar> tbCars = new List<TbCar>();   
            tbCars=oclsCar.GetItemByName(name);
            return View(tbCars);
    }
    }
    
}
