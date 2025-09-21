using System.Globalization;
using ExercicioCsharp_20250919.Entities;

namespace ExercicioCsharp_20250919.Application;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter rental data");
        Console.WriteLine("Car model: ");
        string model = Console.ReadLine();
        Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
        DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        CarRental carRental = new CarRental(start, finish, new Vehicle(model));
        
        
        Console.WriteLine("Enter price per hour: ");
        
        Console.WriteLine("Enter price per day: ");
        
        Console.WriteLine("INVOICE:");
        Console.WriteLine("Basic payment: ");
        Console.WriteLine("Tax: ");
        Console.WriteLine("Total payment: ");
       
       
        
    }
}