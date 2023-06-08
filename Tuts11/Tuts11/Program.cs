namespace Tuts11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TOPIC: OVERLOADING METHOD");
            Console.WriteLine(numbers(50, 100));
            Console.WriteLine(numbers(50, 100, 40));

        }
        static int numbers(int x, int y)
        {
            return x + y;
        }
        static int numbers(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}