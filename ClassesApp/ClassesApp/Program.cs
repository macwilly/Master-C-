namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("A3", "BMW");
            Car bmw = new Car("i7", "Audi");

            audi.Brand = Console.ReadLine();

            Console.WriteLine(audi.AboutCar());

            Console.ReadKey();
        }
    }
}
