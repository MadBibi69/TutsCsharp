namespace Tuts_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            try
            {
                Console.WriteLine("Input number: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine ("The Input number is: " +num);
            }
           catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

        }
    }
}