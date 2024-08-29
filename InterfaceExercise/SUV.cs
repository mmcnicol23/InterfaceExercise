namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    public int NumberOfSeats { get; set; }
    public bool HasThirdRow { get; set; }
    public string Logo { get; set; }
    public string Slogan { get; set; }
}