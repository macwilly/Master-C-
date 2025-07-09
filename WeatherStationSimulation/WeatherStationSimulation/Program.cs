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
            string temps = string.Join(",", temperature);
            averageTemperature = CalculateAverageTempature(temperature);
            int maxTemperature = temperature.Max();
            int minTemperature = temperature.Min();
            string mostCommonCondition = MostCommonWeather(weatherConditions);

            Console.WriteLine($"The list of temps is {temps}");
            Console.WriteLine($"All of the conditions were {string.Join(",", weatherConditions)}");
            Console.WriteLine($"The average temperature is {averageTemperature}");
            Console.WriteLine($"The max temperature is {maxTemperature}");
            Console.WriteLine($"My calculated max is {MaxTemp(temperature)}");
            Console.WriteLine($"The min temperature is {minTemperature}");
            Console.WriteLine($"My calculated min is {MinTemp(temperature)}");
            Console.WriteLine($"Most common weather condion is {mostCommonCondition}");
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

        static string MostCommonWeather(string[] weather)
        {
            int count = 0;
            string mostCommon = weather[0];

            for (int i = 0; i < weather.Length; i++)
            { 
                int tempCount = 0;
                for (int j = 0; j < weather.Length; j++)
                {
                    if (weather[j] == weather[i])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                { 
                    count = tempCount;
                    mostCommon = weather[i];
                }
            }

            return mostCommon;
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
