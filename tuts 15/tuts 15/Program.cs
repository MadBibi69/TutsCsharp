namespace tuts_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Topic: Constractor");
            //Student student1 = new Student(1, "Jerry Barrios", "BSIT", 4);
            //Console.WriteLine(student1.IDno);
            //Console.WriteLine(student1.Fullname);
            //Console.WriteLine(student1.course);
            //Console.WriteLine(student1.studentyear);


            Console.WriteLine("Enter your ID Number: ");
            int inputnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Fullname: ");
            string inputfullname = Console.ReadLine();
            Console.WriteLine("Enter your Course: ");
            string inputcourse = Console.ReadLine();
            Console.WriteLine("Enter your School Year: ");
            int inputyear = int.Parse(Console.ReadLine());
            Student student2 = new Student(inputnumber, inputfullname, inputcourse, inputyear);
            Console.WriteLine(student2.IDno);
            Console.WriteLine(student2.Fullname);
            Console.WriteLine(student2.course);
            Console.WriteLine(student2.studentyear);


        }
    }
}