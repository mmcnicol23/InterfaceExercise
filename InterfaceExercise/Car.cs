namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    public bool HasTrunk { get; set; }
    public string RadioType { get; set; }
    public string Logo { get; set; }
    public string Slogan { get; set; }
    
}