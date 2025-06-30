int numberOfSubmittedScores = 0;
int sumOfSubmittedScores = 0;
bool finishedEnteringScores = false;
bool end = false;
double average = 0.0;
string welcomeMessage = "Welcome to the average calculator. Please enter your scores one at a time.\n " +
        "When you are finished type finished and we will return your average.";


Console.WriteLine(welcomeMessage);

do
{
    int enteredScore = 0;
    string userInput = Console.ReadLine();

    if (userInput.ToLower().Trim() == "finished")
    {
        if (numberOfSubmittedScores > 0)
        {
            average = (double)sumOfSubmittedScores / numberOfSubmittedScores;
            Console.WriteLine($"With {numberOfSubmittedScores} submitted at a total of {sumOfSubmittedScores} you average is {average}");
            Console.WriteLine("\nWould you like to start over? Yes/No");
            //Resetting all of the data
            numberOfSubmittedScores = 0;
            sumOfSubmittedScores = 0;
            average = 0.0;
        }
        else
        {
            Console.WriteLine("Your average is 0. You did not enter any score.\n" +
                "Do you want to start over? Yes/No");
        }

    }
    else if (userInput.ToLower().Trim() == "yes")
    {
        Console.Clear();
        Console.WriteLine(welcomeMessage);

    }
    else if (userInput.ToLower().Trim() == "no")
    {
        finishedEnteringScores = true;
    }
    else if (int.TryParse(userInput, out enteredScore))
    {
        numberOfSubmittedScores++;
        sumOfSubmittedScores += enteredScore;
    }


} while (!finishedEnteringScores);
Console.Clear();

Console.ReadKey();