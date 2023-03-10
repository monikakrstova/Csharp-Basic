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

int PrintNumberDigits ()
{
    int userNumberInput = 0;
    int sum = 0;
    Console.WriteLine("Please enter a number (multiple digits)");
    userNumberInput = Convert.ToInt32(Console.ReadLine());
    int[] numberDigitsArray = userNumberInput.ToString();
    for (int i = 0; i < numberDigitsArrayth; i++)
    {
        sum += numberDigitsArray[i];
    }
}








