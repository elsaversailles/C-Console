using System;

public class Station
{
    public string Name { get; set; }
    public int Distance { get; set; }

    public Station(string name, int distance)
    {
        Name = name;
        Distance = distance;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Modern Jeep Fare Computation");
        Console.WriteLine("Output Route");
        Console.WriteLine("[1] Francisco Homes ");
        Console.WriteLine("[2] Gumaok ");
        Console.WriteLine("[3] Tungko ");
        Console.WriteLine("[4] Pleasant ");
        Console.WriteLine("[5] Malaria ");
        Console.WriteLine("[6] Pangarap ");
        Console.WriteLine("[7] Amparo ");
        Console.WriteLine("[8] Lagro ");
        Console.WriteLine("[9] SM Fairview ");
        Console.WriteLine("[10] Regalado ");
        //1km increment

        Station[] stations = new Station[]
        {
            new Station("Francisco Homes", 0),
            new Station("Gumaok", 1),
            new Station("Tungko", 2),
            new Station("Pleasant", 3),
            new Station("Malaria", 4),
            new Station("Pangarap", 5),
            new Station("Amparo", 6),
            new Station("Lagro", 7),
            new Station("SM Fairview", 8),
            new Station("Regalado", 9)
        };

        Console.WriteLine("Enter Starting Point: ");
        int startStation = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Ending Point: ");
        int endStation = int.Parse(Console.ReadLine());

        // Calculate the distance
        int distance = Math.Abs(stations[endStation - 1].Distance - stations[startStation - 1].Distance);

        // Calculate the fare
        double baseFare = 15.0;
        double additionalFare = 0.0;
        if (distance > 4)
        {
            additionalFare = (distance - 4) * 3.0;
        }
        double totalFare = baseFare + additionalFare;
        
        // Ask for discount
        Console.WriteLine("Do you have a discount? (Y/N): ");
        string discount = Console.ReadLine();
        if (discount.ToUpper() == "Y")
        {
            totalFare *= 0.8; // Apply 20% discount
        }

        // Example usage of the stations array
        Console.WriteLine($"Starting Station: {stations[startStation - 1].Name}, Distance: {stations[startStation - 1].Distance} km");
        Console.WriteLine($"Ending Station: {stations[endStation - 1].Name}, Distance: {stations[endStation - 1].Distance} km");
        Console.WriteLine($"Total Distance: {distance} km");
        Console.WriteLine($"Total Fare: {totalFare} Php");
    }
}
