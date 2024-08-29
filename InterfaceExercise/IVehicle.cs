using System;

namespace InterfaceExercise;

public class IVehicle
{
    
    public int NumberOfWheels { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public long VIN { get; set; }

    public void AboutVehicle()
    {
        Console.WriteLine($"This vehicle is a {Name}");
        Console.WriteLine($"This {Name}'s color is {Color}");
        Console.WriteLine($"This {Name}'s VIN is {VIN}");
        
    }
}