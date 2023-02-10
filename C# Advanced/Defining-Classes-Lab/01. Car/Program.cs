//Create a public class named Car within the namespace CarManufacturer:
//Define in the above class private fields for:
//make: string
//model: string
//year: int
//The class should also have public properties for:
//Make: string
//Model: string
//Year: int
//Create a public class StartUp class within the same namespace CarManufacturer
//to hold your program’s entry point:

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car();

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 2003;

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}