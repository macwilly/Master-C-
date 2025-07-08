namespace WeatherStationSimulation
{
    internal class Program
    {




        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy"};
            string[] weatherConditions = new string[days];
            double averageTempature;

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(0, 101);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            averageTempature = AverageTempature(temperature);

            foreach (int temp in temperature)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine($"The average temperature is {averageTempature}");
            Console.ReadKey();

        }

        static double AverageTempature(int[] temp)
        { 
            double sum = 0;
            double average = 0;
            foreach (int i in temp)
            {
                sum += i;
            }
            average = sum / temp.Length;
            return average;

        }
    }
}
