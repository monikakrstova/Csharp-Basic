using System;

Console.WriteLine("Student Group");
string[] studentsG1 = new string[5] { "Martin", "Tosho", "Monika", "Marija", "Mihail"};
string[] studentsG2 = new string[5] { "Dani", "Hristina", "Ivo", "Dejan", "Mario"};
Console.WriteLine("Plese enter 1 or 2 :)");
bool userInput = int.TryParse(Console.ReadLine(), out int input1);
if (userInput)
{
    if (input1 == 1)
    {
        for (int i = 0; i < studentsG1.Length; i++)
            {
                Console.WriteLine(studentsG1[i]);
            }
    }else if (input1 == 2)
    {
        for (int i = 0; i < studentsG2.Length; i++)
        {
            Console.WriteLine(studentsG2[i]);
        }
    }else
    {
        Console.WriteLine("Wrong input!");
    }
}else
{
    Console.WriteLine("Something went wrong, please try again!");
}


//Excersize 04 

//string[] wordsArray = new string[5] { "Apple", "Banana", "Ginger", "Watermelon", "Lemon" };
//double[] decimalArray = new double[] { 13.6, 5.6, 7.7, 3.13, 0.25, -0.15 };

int Sum (int number1, int number2)
    {
    int sum = number1 + number2;
    return sum;
}

int Subtract (int number1, int number2)
{
    int subtract = number1 - number2;
    return subtract;

}
Console.WriteLine("Please insert + or -");
bool symbol = char.TryParse(Console.ReadLine(), out char validSymbol);

if (symbol)
{
    if (validSymbol == '+')
    {
        Console.WriteLine(Sum(2, 6));
    }else if (validSymbol == '-')
    {
        Console.WriteLine(Subtract(2, 6));
    }
}

