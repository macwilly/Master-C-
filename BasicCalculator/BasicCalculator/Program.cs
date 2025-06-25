// See https://aka.ms/new-console-template for more information
int num1;
int num2;
bool isNumberNum1;
bool isNumberNum2;
string operand;
string message = "";
int result = 0;

Console.WriteLine("Enter the first number:");
isNumberNum1 = int.TryParse(Console.ReadLine(), out num1);

Console.WriteLine("Enter the second number:");
isNumberNum2 = int.TryParse(Console.ReadLine(), out num2);

Console.WriteLine("Choose an operation: +, -, *, /");
operand = Console.ReadLine();

if (isNumberNum1 && isNumberNum2)
{
    switch (operand)
    {
        case "+":
            result = num1 + num2;
            break;
        case "-":
            result = num1 - num2;
            break;
        case "*":
            result = num1 * num2; 
            break;
        case "/":
            if (num2 == 0)
            {
                message = "Error: Division by zero is not allowed.";
            }
            else
            { 
                result = num1 / num2;   
            }
            break;
        default:
            message = "Invalid operation. Please choose +, -, *, or /.";
            break;
    }

    if (message == "")
    {
        message = "Result: " + result;
    }
    Console.WriteLine($"{message}");

}
else
{
    Console.WriteLine("You need to enter a number for both numbers");
}

Console.ReadKey();
