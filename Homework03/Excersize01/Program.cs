
using System;

Console.WriteLine("Sum of Even");
Console.WriteLine("Please enter number 1: ");
bool userInput1 = int.TryParse(Console.ReadLine(), out int number1);
Console.WriteLine("Please enter number 2: ");
bool userInput2 = int.TryParse(Console.ReadLine(), out int number2);
Console.WriteLine("Please enter number 3: ");
bool userInput3 = int.TryParse(Console.ReadLine(), out int number3);
Console.WriteLine("Please enter number 4: ");
bool userInput4 = int.TryParse(Console.ReadLine(), out int number4);
Console.WriteLine("Please enter number 5: ");
bool userInput5 = int.TryParse(Console.ReadLine(), out int number5);
Console.WriteLine("Please enter number 6: ");
bool userInput6 = int.TryParse(Console.ReadLine(), out int number6);

int[] numberArray = new int[6] { number1, number2, number3, number4, number5, number6 };
int sum = 0;
if (userInput1 && userInput2 && userInput3 && userInput4 && userInput5 && userInput6)
{
    

    for (int i = 0; i <6; i++)
    {
        
        if (numberArray[i] % 2 == 0)    
        {
            
            
                sum = +numberArray[i];
                Console.WriteLine(sum);
            
        

        }else
        {
            Console.WriteLine("There are no even numbers in the numbers you entered.");
        }
    }

}
else
{
    Console.WriteLine("Something went wrong, try again!");
}
