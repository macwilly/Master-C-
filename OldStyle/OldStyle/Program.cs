namespace OldStyle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers and I will return the sum.");
            int userFirstNumber = int.Parse(Console.ReadLine());
            int userSecondNumber = int.Parse(Console.ReadLine());
            
            int sum = AddTwoValues(userFirstNumber, userSecondNumber);
            Console.WriteLine(sum);
        }

        static int AddTwoValues(int num1, int num2)
        { 
            int sum = num1 + num2;
            return sum;
        }
    }
}
