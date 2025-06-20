// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a whole number");

int userNumber = int.Parse(Console.ReadLine());

int divisor = 1;
bool isPrime = true;
string isPrimeDisplay = "is not a Prime Number.";

while (isPrime) 
{
    while (divisor < userNumber)
    {

        if ((userNumber % divisor) > 0)
        {
            isPrime = false;
        }
        divisor++;
    }
    break;
}


if (isPrime) { 
    isPrimeDisplay = "is a prime number.";
}

Console.WriteLine($"Your number {userNumber} {isPrimeDisplay}");

Console.ReadLine();

