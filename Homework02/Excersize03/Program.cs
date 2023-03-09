Console.WriteLine("Plese enter a number from 1 to 3:");
bool userInput = int.TryParse(Console.ReadLine(), out int input);

if (userInput)
{
    switch (input)
    {
        case 1:
            Console.WriteLine("You got a new car!");
            break;
        case 2:
            Console.WriteLine("You got a new plane!");
            break;
        case 3:
            Console.WriteLine("You got a new bike!");
            break;
        default:
            Console.WriteLine("Something went wrong. You got nothing!");
            break;
    }
}
