
Console.WriteLine("Swap Numbers");
Console.WriteLine("Please enter number: ");
bool userInput1 = int.TryParse(Console.ReadLine(), out int number1);
Console.WriteLine("Please enter number");
bool userInput2 = int.TryParse(Console.ReadLine(), out int number2);

if (userInput1 && userInput2)
{
    Console.WriteLine("Before swap: " + number1 + " and " + number2);
    number1 = number1 + number2;
    number2 = number1 - number2;
    number1 = number1 - number2;
    Console.WriteLine("After swap: " + number1 + " and " + number2);
}
else
{
    Console.WriteLine("Swaping numbers is not possible!");
}
