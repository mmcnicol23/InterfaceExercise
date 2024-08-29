using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE Create 2 Interfaces called IVehicle & ICompany

            //DONE Create 3 classes called Car , Truck , & SUV

            //DONE In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //DONE In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* DONE Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * DONE Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            var blazer = new SUV();
            blazer.Name = "Chevy Blazer";
            blazer.Color = "blue";
            blazer.VIN = 126654875665134;
            blazer.AboutVehicle();
            Console.WriteLine("------------------------------------------");

            var camry = new Car();
            camry.Name = "Toyota Camry";
            camry.Color = "black";
            camry.VIN = 98564125474521454;
            camry.RadioType = "Sirius XM";
            camry.AboutVehicle();
            Console.WriteLine("------------------------------------------");

            var ram = new Truck();
            ram.Name = "Dodge RAM";
            ram.Color = "steel grey";
            ram.VIN = 6541254789;
            ram.AboutVehicle();


            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
