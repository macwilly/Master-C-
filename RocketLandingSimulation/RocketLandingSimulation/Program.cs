string theRocket = " ^\n||\n M";
string descentChar = "\r\n";
string landed = "The rocket has landed. Woohoo! Another successful landing!";


for (int i = 0; i < 10; i++)
{
    
    Console.WriteLine(theRocket);
    theRocket = descentChar + theRocket;
    
    Thread.Sleep(800);
    Console.Clear();
}

Console.WriteLine(landed);

Console.ReadKey();