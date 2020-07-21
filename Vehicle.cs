using System;

namespace garys_garage
{

    public class Vehicle
{
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public virtual void Drive(){
        Console.WriteLine("Vrooooooooooom!");
    }

    public virtual void Turn(string direction){
        Console.WriteLine($"The {this.MainColor} {this.GetType().ToString().Split(".")[1]} turns {direction}");
    }

    public virtual void Stop(){
        Console.WriteLine($"The {this.MainColor} {this.GetType().ToString().Split(".")[1]} rolls to a stop.");
    }

}

}