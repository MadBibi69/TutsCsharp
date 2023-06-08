using Microsoft.VisualBasic;

namespace tuts14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TOPIC OOP");
            Person person = new Person();
            person.firstname = "Jerry";
            person.lastname = "Barrios";
            person.age = 20;
            Console.Write("my fullname is: ");
            Console.WriteLine(person.firstname + " " + person.lastname);
            Console.Write("my age is: ");
            Console.Write(person.age);
        }
    }
}