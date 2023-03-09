Console.WriteLine("Please enter fisrt number:");
bool userInput1 = int.TryParse(Console.ReadLine(), out int number1);
Console.WriteLine("Please enter second number:");
bool userInput2 = int.TryParse(Console.ReadLine(), out int number2);
if (userInput1 && userInput2)
{
    if (number1 > number2)
    {
        if (number1 % 2 == 0)
        {
            Console.WriteLine(number1 + " is bigger than " +  number2 + " and is even number.");
        }else
        {
            Console.WriteLine(number1 + " is bigger than " + number2 + " and is odd number.");
        }
    }else if (number1 < number2)
    {
        if (number1 % 2 == 0)
        {
            Console.WriteLine(number2 + " is bigger than " + number1 + " and is even number.");
        }else
        {
            Console.WriteLine(number2 + " is bigger than " + number1 + " and is odd number.");
        }
    }else
    {
        Console.WriteLine("The two numbers that you entered are even.");
    }
    
}

