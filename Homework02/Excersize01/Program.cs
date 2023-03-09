Console.WriteLine("Excersize 6 - Problem solution");
int numberOfBranches = 12;
int applesOnBranch = 8;
int applesInBasket = 5;
Console.WriteLine("Please enter number of trees:");
bool userInput = int.TryParse(Console.ReadLine(), out int treeNumber);

if (userInput)
{
    int numberOfBaskets = treeNumber * numberOfBranches * applesOnBranch / applesInBasket;
    Console.WriteLine("For " + treeNumber + " trees, you need " + numberOfBaskets + " baskets to colect all apples.");
}else
{
    Console.WriteLine("Plese insert a number!");
}
