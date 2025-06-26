using System.Linq.Expressions;

string characterName = "";
string characterClass = "";
int characterClassInt = 0;
string classList = "\n 1) Warrior\n 2) Wizard\n 3) Archer";
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
        else { 
            characterClass = classInput;
        }
    }
}

Console.WriteLine($"Welcome {characterName} you will make a fine {characterClass}");

Console.ReadKey();