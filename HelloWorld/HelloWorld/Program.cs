// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Will!");

// Declare a variable
string myFriendsName;
string myOtherFriend = "Milkshake";

// assign a value
myFriendsName = "Otto";

// use the variable
Console.WriteLine(myFriendsName);

// overriding the variable value
myFriendsName = "Zozo";

Console.WriteLine(myFriendsName);

Console.WriteLine(myOtherFriend);



string[] daysOfTheWeek = ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"];

foreach (string day in daysOfTheWeek)
{
    Console.WriteLine(day);
}

for (int i = 0; i < daysOfTheWeek.Length; i++)
{
    Console.WriteLine(daysOfTheWeek[i]);
}

// This will keep Console open
Console.ReadKey();