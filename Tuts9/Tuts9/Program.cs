namespace Tuts9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TOPICS: PARAMETERS");
            nums(50, 50);
            Console.WriteLine("The Answer is: " +numbers(5, 50));
           

        }

        static void  nums(int x, int y)
        {
            Console.WriteLine("the first number is: " + x);
            Console.WriteLine("the second number is: " + y);
        }
        static int numbers(int c, int z)
        {
            return  c + z;
        }


    }
}