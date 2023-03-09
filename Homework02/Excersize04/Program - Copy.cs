Console.WriteLine("Calculator");
Console.WriteLine("Please enter number");
bool userInput1 = int.TryParse(Console.ReadLine(), out int number1);
Console.WriteLine("Please enter number");
bool userInput2 = int.TryParse(Console.ReadLine(), out int number2);
Console.WriteLine("Please enter operator +, -, * or /");
string userInput3 = Convert.ToString(Console.ReadLine());

if (userInput1 && userInput2)
{   
    if (userInput3 == "+" )
    {
        int sum = number1 + number2;
        Console.WriteLine("The sum of " + number1 + " and " + number2 + " is: " + sum);
    }else if (userInput3 == "-" )
    {
        int subtraction = number1 - number2;
        Console.WriteLine("The subtraction of " + number1 + " and " + number2 + " is: " + subtraction);
    }else if(userInput3 == "*")
    {
        int multiplication = number1 * number2;
        Console.WriteLine("The multiplication of " + number1 + " and " + number2 + " is: " + multiplication);
    }else if (userInput3 == "/")
    {
        int devision = number1 / number2;
        Console.WriteLine("The devision of " + number1 + " and " + number2 + " is: " + devision);
    }else
    {
        Console.WriteLine("You entered non valid symbol!");
    }
}else
{
    Console.WriteLine("Something went wrong, please try again!");
}

