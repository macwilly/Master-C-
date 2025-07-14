namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("A3", "BMW", false);
            Car bmw = new Car("i7", "Audi", true);

            audi.Brand = Console.ReadLine();

            Console.WriteLine(audi.AboutCar());

            Console.ReadKey();
        }
    }
}
