// See https://aka.ms/new-console-template for more information

string question1 = "What is the capital of Germany?";
string answer1 = "Berlin";
string question2 = "What is 2 + 2?";
string answer2 = "4";
string question3 = "What color do you get when you mix blue and yellow?";
string answer3 = "Green";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();

if (userAnswer1.ToLower().Trim() == answer1.ToLower())
{
    Console.WriteLine("Correct");
    score++;
}
else
{
    Console.WriteLine($"Incorrect. The correct answer is {answer1}");
}


Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();

if (userAnswer2.Trim() == answer2)
{
    Console.WriteLine("Correct");
    score++;
}
else
{
    Console.WriteLine($"Incorrect. The correct answer is {answer2}");
}



Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();

if (userAnswer3.ToLower().Trim() == answer3.ToLower())
{
    Console.WriteLine("Correct");
    score++;
}
else
{
    Console.WriteLine($"Incorrect. The correct answer is {answer3}");
}

Console.WriteLine($"Your final score was {score}/3");

if (score == 3)
{
    Console.WriteLine("Excellent! You got all questions correct!");
}
else if (score > 0)
{
    Console.WriteLine("Good job, but keep learning");
}
else
{
    Console.WriteLine("Nothing correct, study harder and try again.");
}
Console.ReadKey();