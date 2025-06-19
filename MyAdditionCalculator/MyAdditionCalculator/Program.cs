// See https://aka.ms/new-console-template for more information
// Prints what is inside the brackets
Console.WriteLine("Enter A Number!");

int myFirstNumber = 0;
int mySecondNumber = 0;
int sumOfUserInput = 0;

// takes the user input and stores it
string userInput = Console.ReadLine();
//myNumber = int.Parse(Console.ReadLine());
myFirstNumber = int.Parse(userInput);

Console.WriteLine("Enter a second number");

userInput = Console.ReadLine();
mySecondNumber = int.Parse(userInput);

sumOfUserInput = myFirstNumber + mySecondNumber;

Console.WriteLine($"{myFirstNumber} plus {mySecondNumber} = {sumOfUserInput}");

Console.ReadKey();