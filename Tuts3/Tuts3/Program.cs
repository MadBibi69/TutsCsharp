namespace Tuts3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TOPIC 3: FUNCTIONS");
            Console.WriteLine("Sum of two numbers :" + Sumoftwonumbers());
            Console.WriteLine("Answer :" + Isnumberless());
            Console.WriteLine("my name is  :" + Myname());

        }

        static int Sumoftwonumbers()
        {
            int x = 1;
            int y = 5;
            return x + y;

        }

        static bool Isnumberless()
        {
            if (40 < 30)
                return false;
            else
            {
                return true;
            }
        }

        static string  Myname()
        {
            return "Jerry";
        }
    }
}