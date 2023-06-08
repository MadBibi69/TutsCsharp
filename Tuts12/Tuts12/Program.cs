namespace Tuts12
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            ValorantAgent student = new ValorantAgent();
            Console.WriteLine("TOPIC: CLASSES");
            student.agent("jett","Duel");

            student.ability("updraft", 450);

            valorantmap map = new valorantmap();
            map.map();
            Console.WriteLine(map.map());
        }
    }
    class ValorantAgent
    {
        public string agent(string name, string role)
        {
            Console.WriteLine("Agent name: " + name);
            Console.WriteLine("Agent Role: " + role);
            return name + role;
        }
        public void ability(string abilityname, int cost)
        {
            Console.WriteLine("Ability cost: " + cost);
            Console.WriteLine("Ability Name: " + abilityname);
        }
    }
    class valorantmap
    {
        public bool map()
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