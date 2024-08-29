namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public bool IsAWD { get; set; }
    public string TowingCapacity { get; set; }
    public string Logo { get; set; }
    public string Slogan { get; set; }
}