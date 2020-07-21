using System;

namespace garys_garage
{
    public class Tesla : Vehicle
    {  // Electric car
        public double BatteryKWh { get; set; }

        public void ChargeBattery() { }

        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} {this.GetType().ToString().Split(".")[1]} drives past.  Hummmmmmmmm!");

        }
    }
}