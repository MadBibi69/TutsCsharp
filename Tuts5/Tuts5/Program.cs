namespace Tuts5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //string[] names = { "Jerry", "Eddy", "Sai" };
            //Console.WriteLine(names[0]);

            //for (int x = 0; x < names.Length; x++)
            //{
            //    Console.WriteLine("Name: " + names[x]);
            //}

            //foreach (string Names in names)
            //{
            //    Console.WriteLine(Names);
            //}

            //Type casting
            Console.WriteLine("Enter your Name: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Your Name is: " + name);
        }
    }
}