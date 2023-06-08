using System.Diagnostics;

namespace Tuts7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi("Jerry");
            number();
            Console.WriteLine(num());
        }
        static  void SayHi(string hello)
        {
            Console.WriteLine(hello +  "greetings");

        }
        static int number()
        {
            int x = 5;
            Console.WriteLine(x);
            return x;
        }

        static bool num()
        {
            if(1 < 2)
            {
                return true;
            }
            else
            {
                 return false;
            }
        }
    }
}