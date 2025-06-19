// See https://aka.ms/new-console-template for more information
// Prints what is inside the brackets
Console.WriteLine("Enter A Number!");

double myFirstNumber = 0;
double mySecondNumber = 0.0;
double sumOfUserInput = 0.0;

// takes the user input and stores it
string userInput = Console.ReadLine();
//myNumber = int.Parse(Console.ReadLine());
myFirstNumber = double.Parse(userInput);

Console.WriteLine("Enter a second number");

userInput = Console.ReadLine();
mySecondNumber = double.Parse(userInput);

sumOfUserInput = myFirstNumber + mySecondNumber;

Console.WriteLine($"{myFirstNumber} plus {mySecondNumber} = {sumOfUserInput}");

Console.ReadKey();