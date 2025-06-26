Random random = new Random();
int numberOfGuesses = 0;
int startNumber = 1;
int endNumber = 100;
int hiddenNumber = random.Next(startNumber, endNumber);
int userGuessedNumber = 0;

Console.WriteLine($"Guess a number between {startNumber} and {endNumber}");
numberOfGuesses++;
int.TryParse(Console.ReadLine(), out userGuessedNumber);

while (userGuessedNumber != hiddenNumber)
{
    if (userGuessedNumber > hiddenNumber)
    {
        Console.WriteLine("The number you guessed was higher than the hidden number. Guess again.");
        numberOfGuesses++;
        int.TryParse(Console.ReadLine(), out userGuessedNumber);
    }
    else
    {
        Console.WriteLine("The number you guessed was lower than the hidden number. Guess again.");
        numberOfGuesses++;
        int.TryParse(Console.ReadLine(), out userGuessedNumber);
    }
}

Console.WriteLine($"You got it! The hidden number was {hiddenNumber}. It took you {numberOfGuesses} guesses.");
Console.ReadLine();