namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the main use of your vheicle?");
            Console.WriteLine("Choose from Passenger, Cargo, Both.");
            string userInput = Console.ReadLine();

            VehicleFactory factory = new VehicleFactory();
            IVehicle myCar = factory.Create(userInput);
        }
    }
}
