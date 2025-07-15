namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car audi = new Car("A3", "BMW", false);
            //Car bmw = new Car("i7", "Audi", true);

            //audi.Brand = Console.ReadLine();

            //Console.WriteLine(audi.AboutCar());

            Customer customer1 = new Customer("David");
            Customer customer2 = new Customer("Frank the Tank", "1 Main ST", "13-858-7895");
            Customer customer3 = new Customer();
            Console.WriteLine("Name of Customer " + customer1.Name);
            Console.WriteLine("Name of Customer " + customer2.Name);
            Console.WriteLine("Name of Customer " + customer3.Name);
            

            Console.WriteLine("Please enter customer name.");

            customer3.Name = Console.ReadLine();
            Console.WriteLine("Name of Customer " + customer3.Name);


            Console.ReadKey();
        }
    }
}
