using System.Globalization;

// See https://aka.ms/new-console-template for more information
// Prints what is inside the brackets
Console.WriteLine("Enter A Number!");

double myFirstNumber  = 0;
double mySecondNumber = 0.0;
double sumOfUserInput = 0.0;

string displayFirstNumber  = "";
string displaySecondNumber = "";
string displaySum          = "";

// takes the user input and stores it
string userInput = Console.ReadLine();
//myNumber = int.Parse(Console.ReadLine());
myFirstNumber = double.Parse(userInput, System.Globalization.CultureInfo.InvariantCulture);

Console.WriteLine("Enter a second number");

userInput = Console.ReadLine();
mySecondNumber = double.Parse(userInput, System.Globalization.CultureInfo.InvariantCulture);

sumOfUserInput = myFirstNumber + mySecondNumber;

//Forcing the sum to two decimal points
sumOfUserInput = Math.Round(sumOfUserInput, 2);

//Formating the output to only show two decimal places
Console.WriteLine($"{myFirstNumber:F2} plus {mySecondNumber:F2} = {sumOfUserInput:F2}");

Console.ReadKey();