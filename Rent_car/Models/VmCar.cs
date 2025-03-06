namespace Rent_car.Models
{
    public class VmCar
    {
        public TbCar CarDetails { get; set; }
        public List<TbCar> RecommendedCar { get; set; }
    }
}
