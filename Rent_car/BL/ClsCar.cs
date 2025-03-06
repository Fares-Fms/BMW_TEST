using Rent_car.Models;

namespace Rent_car.BL
{
   public interface ICar
    {
        public List<TbCar> GetCars();
        public TbCar GetCarById(int Id);
        public List<TbCar> GetRecommendedCars(int id);
        public List<TbCar> GetItemByName(string name);
    }

    public class ClsCar : ICar
    {
        BmwContext _context;
        public ClsCar(BmwContext context)
        {
            _context = context;
        }
        public List<TbCar> GetCars()
        {
            List<TbCar > cars = new List<TbCar>();
            cars= _context.TbCars.ToList();
            return cars;
        }
        public TbCar GetCarById(int Id)
        {

            try
            {

                var car = _context.TbCars.FirstOrDefault(a => a.CarId == Id);
                return car;
            }
            catch
            {
                return new TbCar();
            }
        }
        public List<TbCar> GetRecommendedCars(int id)

        {
            try
            {
                var Car = GetCarById(id);
                var LstCars = _context.TbCars.Where(a => (a.Price >= Car.Price)&&(a.CarId != Car.CarId) ).ToList();
                return LstCars;
            }
            catch
            {
                return new List<TbCar>();
            }
        }
        public List<TbCar> GetItemByName(string name)
        {
            try
            {

                var cars = _context.TbCars.Where(a => (a.CarName.Contains(name)) && (a.CurrentState != 0)).Take(25).ToList();
                return cars;
            }
            catch
            {
                return new List<TbCar>();
            }
        }
    }
}
