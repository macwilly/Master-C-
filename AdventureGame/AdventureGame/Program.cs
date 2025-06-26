string characterName = "";
string characterClass = "";
int characterClassInt = 0;
bool choseToEnterOrCamp = false;
string classList = "\n 1) Warrior\n 2) Wizard\n 3) Archer";
string forestOrCamp = "Do you enter the (f)orest or (c)amp out?";
Console.WriteLine("Welcome to the Adventure Game!");
Console.WriteLine("Enter your charater's name: ");
characterName = Console.ReadLine();
Console.WriteLine($"Choose your Class:{classList}");
var classInput = Console.ReadLine();

while (characterClass == "")
{
    if (int.TryParse(classInput, out characterClassInt))
    {
        switch (characterClassInt)
        {
            case 1:
                characterClass = "Warrior";
                break;
            case 2:
                characterClass = "Wizard";
                break;
            case 3:
                characterClass = "Archer";
                break;
            default:
                Console.WriteLine($"Please Choose one of the avaiable classes:{classList}");
                classInput = Console.ReadLine();
                break;
        }
    }
    else
    {
        string localClass = classInput.ToLower().Trim();
        if (localClass != "warrior" && localClass != "wizard" && localClass != "archer")
        {
            Console.WriteLine($"Please choose one of the class:{classList}");
            classInput = Console.ReadLine();
        }
        else
        {
            characterClass = classInput;
        }
    }
}

Console.WriteLine($"Welcome {characterName} you will make a fine {characterClass}.\n You find yourself at the edge of the Dark Forest.\n {forestOrCamp}");

string enterForestOrCamp = Console.ReadLine();

while (!choseToEnterOrCamp)
{
    string localForestOrCamp = enterForestOrCamp.ToLower().Trim();
    if (localForestOrCamp != "f" && localForestOrCamp != "forest" && localForestOrCamp != "c" && localForestOrCamp != "camp" && localForestOrCamp != "camp out")
    {
        Console.WriteLine($"Brave {characterName} the {characterClass} that is not a valid option.\n {forestOrCamp}");
        enterForestOrCamp = Console.ReadLine();
    }
    else
    {
        choseToEnterOrCamp = true;
    }
}

if (enterForestOrCamp.ToLower().Trim() == "f" || enterForestOrCamp.ToLower().Trim() == "forest")
{
    Console.WriteLine("You boldly enter The Dark Forest. Not fearing what lies ahead!");
}
else 
{
    Console.WriteLine("You decided to camp out and wait fot the light of day."); 
}

Console.ReadKey();