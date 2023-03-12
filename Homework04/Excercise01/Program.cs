//Таск 01-Take one string from the input and print its last 5 characters.
//Console.WriteLine("Please enter a word: ");
//string userInput = Console.ReadLine();
//string newString = userInput.Substring(userInput.Length - 5);
//Console.WriteLine(newString);


//Task 02-Take a sentence as input and print its words.

//Console.WriteLine("Please enter a sentence:");
//string splitToWordsArray = Convert.ToString(Console.ReadLine());
//string[] newSplittedArray = splitToWordsArray.Split(" ");
//for (int i = 0; i < newSplittedArray.Length; i++)
//{
//    Console.WriteLine(newSplittedArray[i]);
//}



//Task 03-Create a function that takes a number as input. This method should return the sum of the digits in the number.

//void SumNumberDigits ()
//{
//    int sum = 0;
//    Console.WriteLine("Please enter a number (multiple digits)");
//    int userNumberInput = Convert.ToInt32(Console.ReadLine());
//    while (userNumberInput != 0)
//    {
//        sum += userNumberInput % 10;
//        userNumberInput /= 10;
//    }
//    Console.WriteLine("The sum of the digits is: " + sum);
//}

//SumNumberDigits();

//Task 4
//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date
//Note: take into consideration if the birthday is today, after or before today



int AgeCalculator(DateTime dateOfBirth)
{
    int age = 0;
    age = DateTime.Today.Year - dateOfBirth.Year;
    return age;
    
}

DateTime birthday1 = new DateTime(1996, 4, 23);
DateTime birthday2 = new DateTime(2000, 11, 25);
DateTime birthday3 = new DateTime(1971, 4, 13);
DateTime birthday4 = new DateTime(1973, 8, 4);
DateTime birthdayToday = DateTime.Now;
Console.WriteLine($"You are {AgeCalculator(birthday1)} years old!");
Console.WriteLine($"You are {AgeCalculator(birthday2)} years old!");
Console.WriteLine($"You are {AgeCalculator(birthday3)} years old!");
Console.WriteLine($"You are {AgeCalculator(birthday4)} years old!");











Console.ReadLine();




