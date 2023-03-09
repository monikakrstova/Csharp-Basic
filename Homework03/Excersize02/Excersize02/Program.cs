using System;

//Console.WriteLine("Student Group");
//string[] studentsG1 = new string[5] { "Martin", "Tosho", "Monika", "Marija", "Mihail"};
//string[] studentsG2 = new string[5] { "Dani", "Hristina", "Ivo", "Dejan", "Mario"};
//Console.WriteLine("Plese enter 1 or 2 :)");
//bool userInput = int.TryParse(Console.ReadLine(), out int input1);
//if (userInput)
//{
//    if (input1 == 1)
//    {
//        for (int i = 0; i < studentsG1.Length; i++)
//            {
//                Console.WriteLine(studentsG1[i]);
//            }
//    }else if (input1 == 2)
//    {
//        for (int i = 0; i < studentsG2.Length; i++)
//        {
//            Console.WriteLine(studentsG2[i]);
//        }
//    }else
//    {
//        Console.WriteLine("Wrong input!");
//    }
//}else
//{
//    Console.WriteLine("Something went wrong, please try again!");
//}


//Excersize 04 

string[] wordsarray = new string[5] { "apple", "banana", "ginger", "watermelon", "lemon" };
double[] decimalarray = new double[] { 13.6, 5.6, 7.7, 3.13, 0.25, -0.15 };
char[] charactersArray = new char[] { 's', 'h', 'a', 'r', 'p' };
bool[] boolArray = new bool[5] { false, true, true, true, false };
int[][] twoArrays = new int[3][]
{
    new int[] {1, 2},
    new int[] {4, 5},
    new int[] {7, 8},
};

//Excersize 05

//int[] inputNumbers = new int[5];
//for (int i = 0; i< inputNumbers.Length;i++)
//{
//    Console.WriteLine($"Enter value {i + 1}: ");
//    inputNumbers[i] = int.Parse(Console.ReadLine());
//}

//int sum = 0;
//foreach (int number in inputNumbers)
//{
//    sum += number;
//}

//Console.WriteLine("The sum of the numbers is: " + sum);

//Excersize 06
string[] namesArray = new string[50];
int i = 0;
string input = "";

do
{
    Console.WriteLine("Enter a name:");
    input = Console.ReadLine();
    namesArray[i] = input;
    i++;
    Console.WriteLine("Do you want to enter another name? Y for Yes and N for No");
    input = Console.ReadLine();

}
while (input.ToUpper() == "Y");

Console.WriteLine("Here are all the names that you entered:");
for (int y = 0; y<i; y++)
{
    Console.WriteLine(namesArray[y]);
}

