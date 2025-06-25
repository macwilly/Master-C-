// See https://aka.ms/new-console-template for more information
Console.WriteLine("Give a number");

string userInput = Console.ReadLine();
int num1;

if (!int.TryParse(userInput, out num1)) 
{
    Console.WriteLine("Please Write a number, if not the answer will be 1");
    int.TryParse(Console.ReadLine(), out num1 );
}


num1++;
Console.WriteLine($"User entered {userInput} +1 = {num1}");
Console.ReadKey();