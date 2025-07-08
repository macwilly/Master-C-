namespace WeatherStationSimulation
{
    internal class Program
    {




        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];
            double averageTemperature;

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(0, 101);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            averageTemperature = CalculateAverageTempature(temperature);
            int maxTemperature = temperature.Max();
            int minTemperature = temperature.Min();
            foreach (int temp in temperature)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine($"The average temperature is {averageTemperature}");
            Console.WriteLine($"The max temperature is {maxTemperature}");
            Console.WriteLine($"My calculated max is {MaxTemp(temperature)}");
            Console.WriteLine($"The min temperature is {minTemperature}");
            Console.WriteLine($"My calculated min is {MinTemp(temperature)}");
            Console.ReadKey();

        }

        static double CalculateAverageTempature(int[] temp)
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

        static int MaxTemp(int[] temp)
        {
            int max = temp[0];
            foreach (int i in temp)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        static int MinTemp(int[] temp)
        {
            int min = temp[0];
            foreach (int i in temp)
            {
                if (i < min)
                { 
                    min = i;
                }
            }
            return min;
        }
    }
}
