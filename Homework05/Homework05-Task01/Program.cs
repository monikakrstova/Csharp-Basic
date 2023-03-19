using Homework05_Task01.Models;

namespace Homework05_Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name, last name and age:");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Age: ");
            bool ageInput = int.TryParse(Console.ReadLine(), out int age);

            Human human = new Human() { FirstName = firstName, LastName = lastName, Age = age};

            Console.WriteLine(human.GetPersonDetails());
        }
    }
}