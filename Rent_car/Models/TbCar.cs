using System;
using System.Collections.Generic;

namespace Rent_car.Models;

public partial class TbCar
{
    public int CarId { get; set; }

    public string CarName { get; set; } = null!;

    public decimal Price { get; set; }

    public string? ImageName { get; set; }

    public int? CurrentState { get; set; }

    public string? Engine { get; set; }

    public string? Fuel { get; set; }

    public string? Model { get; set; }

    public int? Range { get; set; }

    public string? Weight { get; set; }

    public int? Hp { get; set; }
}
