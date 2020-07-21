using System;

namespace garys_garage{

    public class Cessna : Vehicle {  // Propellor light aircraft
    public double FuelCapacity { get; set; }
    public void RefuelTank () { }

     public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} {this.GetType().ToString().Split(".")[1]} fly overhead.  Vroooooooommmm!");

        }

         public override void Turn(string direction)
        {
            Console.WriteLine($"The {this.MainColor} {this.GetType().ToString().Split(".")[1]} banks {direction}.");

        }

         public override void Stop()
        {
            Console.WriteLine($"The {this.MainColor} {this.GetType().ToString().Split(".")[1]} screeches to a halt on the runway.");

        }
}
}