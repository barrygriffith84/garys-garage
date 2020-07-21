using System;
using System.Collections.Generic;

namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero myMotorcycle = new Zero();
            myMotorcycle.MainColor = "Red";
            myMotorcycle.MaximumOccupancy = "2";
            myMotorcycle.BatteryKWh = 18;

            Tesla modelThree = new Tesla();
            modelThree.MainColor = "Black";
            modelThree.MaximumOccupancy = "5";
            modelThree.BatteryKWh = 75;

            Cessna traffickingPlane = new Cessna();
            traffickingPlane.MainColor = "White";
            traffickingPlane.MaximumOccupancy = "3";
            traffickingPlane.FuelCapacity = 56;

            Ram muddinTruck = new Ram();
            muddinTruck.MainColor = "Real-Tree Camo";
            muddinTruck.MaximumOccupancy = "12";
            muddinTruck.FuelCapacity = 23;

            List<Vehicle> garage = new List<Vehicle>();
            garage.Add(myMotorcycle);
            garage.Add(modelThree);
            garage.Add(traffickingPlane);
            garage.Add(muddinTruck);

            modelThree.Drive();
            traffickingPlane.Drive();
            myMotorcycle.Drive();
            muddinTruck.Drive();

            modelThree.Turn("right");
            traffickingPlane.Turn("left");
            myMotorcycle.Turn("right");
            muddinTruck.Turn("left");

            modelThree.Stop();
            traffickingPlane.Stop();
            myMotorcycle.Stop();
            muddinTruck.Stop();


        }
    }
}
