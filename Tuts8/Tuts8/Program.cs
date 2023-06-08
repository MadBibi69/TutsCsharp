namespace Tuts8
{
    internal class Program
    {
        //global scope
       static int globalage = 100;
        static void Main(string[] args)
        {
            
            Console.WriteLine("TOPIC ");
            int age = 20;
            //Console.WriteLine(age);
            //names();
            Console.WriteLine(globalage);

        }

        static void names()
        {
            int myage = 30;
            Console.WriteLine(myage);
        }
    }
}