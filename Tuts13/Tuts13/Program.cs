namespace Tuts13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TOPIC STATIC");
            Greetings greetings = new Greetings();
            greetings.charInfo("Phoenix", 24);
            Numbers numbers = new Numbers();
            Console.WriteLine(Numbers.add(10, 50));
            Console.WriteLine(Numbers.mult(10, 3));


        }
    }

    //class
    public class Greetings
    {
        public void charInfo(string name, int age)
        {
            Console.WriteLine("Char info");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("age: " + age);
        }
    }
    class Numbers
    {
        public static int add(int x, int y)
        {
            return x + y;

        }
        public static int mult(int a, int b)
        {
            return a * b;
        }
    }
}