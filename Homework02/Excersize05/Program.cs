
Console.WriteLine("Average Number");
Console.WriteLine("Please enter number");
bool userInput1 = int.TryParse(Console.ReadLine(), out int number1);
Console.WriteLine("Please enter number");
bool userInput2 = int.TryParse(Console.ReadLine(), out int number2);
Console.WriteLine("Please enter number");
bool userInput3 = int.TryParse(Console.ReadLine(), out int number3);
Console.WriteLine("Please enter number");
bool userInput4 = int.TryParse(Console.ReadLine(), out int number4);

if (userInput1 && userInput2 && userInput3 && userInput4)
{
    int sum = number1 + number2 + number3 + number4;
    int average = sum / 4;
    Console.WriteLine("The average of: " + number1 + ", " + number2 + ", " + number3 + " and " + number4 + " is: " + average);
}else
{
    Console.WriteLine("Wrong input!");
}