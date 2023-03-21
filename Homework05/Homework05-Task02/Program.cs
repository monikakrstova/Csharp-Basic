using Homework05_Task02.Models;
using System;

namespace Homework05_Task02
{
    public class Program
    {
        static void Main(string[] args)
        {
            void RaceCars (Car firstCar, Car secondCar)
            {
                if (firstCar.CalculateSpeed(firstCar.Driver) > secondCar.CalculateSpeed(secondCar.Driver))
                {
                    Console.WriteLine($"In the race the winner car was {firstCar.Model}. It was driving with {firstCar.Speed}km/h and the driver was {firstCar.Driver.Name}");
                }else if (firstCar.CalculateSpeed(firstCar.Driver) < secondCar.CalculateSpeed(secondCar.Driver)) {
                    Console.WriteLine($"In the race the winner car was {secondCar.Model}. It was driving with {secondCar.Speed}km/h and the driver was {secondCar.Driver.Name}");
                }else
                {
                    Console.WriteLine("They are equal!");
                }
            }

            Car car1 = new Car() { Model = "Aston Martin", Speed = 180};
            Car car2 = new Car() { Model = "Ferrari", Speed = 220 };
            Car car3 = new Car() { Model = "Bugatti", Speed = 190 };
            Car car4 = new Car() { Model = "McLaren", Speed = 210 };
            Car[] cars = new Car[] { car1, car2, car3, car4 };
            Driver driver1 = new Driver() { Name = "Marija", Level = 4 };
            Driver driver2 = new Driver() { Name = "Monika", Level = 5 };
            Driver driver3 = new Driver() { Name = "Dani", Level = 5 };
            Driver driver4 = new Driver() { Name = "Hristina", Level = 3 };
            Driver[] drivers = new Driver[] { driver1, driver2, driver3, driver4 };
            bool endGame = true;

            do
            {

                Console.WriteLine($"Please select the first car: \n1.{car1.Model} \n2.{car2.Model} \n3.{car3.Model} \n4.{car4.Model}");
                bool firstCarparsed = int.TryParse(Console.ReadLine(), out int firstCar);
                Console.WriteLine($"Please select the second car: \n1.{car1.Model} \n2.{car2.Model} \n3.{car3.Model} \n4.{car4.Model}");
                bool secondCarparsed = int.TryParse(Console.ReadLine(), out int secondCar);
                Console.WriteLine($"Please select the first driver: \n1.{driver1.Name} \n2.{driver2.Name} \n3.{driver3.Name} \n4.{driver4.Name}");
                bool firstDriverparsed = int.TryParse(Console.ReadLine(), out int firstDriver);
                Console.WriteLine($"Please select the second driver: \n1.{driver1.Name} \n2.{driver2.Name} \n3.{driver3.Name} \n4.{driver4.Name}");
                bool secondDriverparsed = int.TryParse(Console.ReadLine(), out int secondDriver);

                if (firstCarparsed && secondCarparsed && firstDriverparsed && secondDriverparsed)
                {
                    Car firstCarSelected = cars[firstCar - 1];
                    Car secondCarSelected = cars[secondCar - 1];

                    Driver firstDriverSelected = drivers[firstDriver - 1];
                    Driver secondDriverSelected = drivers[secondDriver - 1];

                    firstCarSelected.Driver = firstDriverSelected;
                    secondCarSelected.Driver = secondDriverSelected;

                    RaceCars(firstCarSelected, secondCarSelected);

                    Console.WriteLine("Do you want to race again? If you want to continue enter yor Y, otherwise enter n or N");
                    string userInput = Console.ReadLine();
                    if (userInput.ToLower() == "n")
                    {
                        endGame = false;
                    }

                }
                else
                {
                    Console.WriteLine("Wrong input. Please select number from 1 to 4");
                }
            } while (endGame);
        }
    }
}