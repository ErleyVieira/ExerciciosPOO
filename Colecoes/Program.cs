using System.Globalization;
using Colecoes.Helper;

System.Console.WriteLine("Enter rental data");
System.Console.Write("Car model: ");
string carModel = Console.ReadLine();
System.Console.Write("Pickup (dd/MM/yyyy hh:mm):");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:ss", CultureInfo.InvariantCulture);
System.Console.Write("Return (dd/MM/yyyy hh:mm):");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:ss", CultureInfo.InvariantCulture);

CarRental carRental = new CarRental (start, finish, new Vehicle(carModel));