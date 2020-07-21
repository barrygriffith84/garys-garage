using System;

namespace garys_garage
{

    public class Zero : Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }
        public void ChargeBattery() { }

        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} {this.GetType().ToString().Split(".")[1]} wizzes past.  Hummmmmmmmm!");

        }
    }

}