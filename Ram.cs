using System;

namespace garys_garage {

public class Ram : Vehicle {  // Gas powered truck
    public double FuelCapacity { get; set; }
    public void RefuelTank () { }

    public override void Drive() {
        Console.WriteLine($"The {this.MainColor} {this.GetType().ToString().Split(".")[1]} drives past.  Vrooooooom!");
    }
}

}