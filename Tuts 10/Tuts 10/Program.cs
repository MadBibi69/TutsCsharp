namespace Tuts_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Car info");
            Console.WriteLine(cars("Toyota", "Lambo"));
            Console.Write(grades(90, 84));


        }
        static string cars(string brand, string name)
        {
            return brand + " " + name;
        }

        static int grades(int studentone, int studenttwo)
        {
            return studentone + studenttwo;
        }

    }
}