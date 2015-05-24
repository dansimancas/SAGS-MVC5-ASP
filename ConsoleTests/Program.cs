using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            ScoutGroup sg = ScoutGroup.getInstance();
            //sg.setScoutGroupData("123", "aguilas negras", "colombia", "cartagena", "olaya", "angel");
            Console.WriteLine(sg.ToString());
            sg.editScoutGroupData("las aguilas negras", 456, "medellin", "antioquia", "colombia", "itagui", "daniela");
            Console.WriteLine(sg.ToString());
            /*
            Console.WriteLine("\nGroup name: " + sg.Name);
            sg.Name = "micaela";
            Console.WriteLine(sg.ToString());*/
            Teen t = new Teen("daniela", "simancas", "female", "torices", "cartagena", null, 123, 1050962143, null);
            Scouter s = new TeenToScouterAdapter(t);
            Console.WriteLine(s.ToString());

            Console.WriteLine("\nOBSERVER TESTS\n");

            //Activity a1 = new Activity(new List<IObserver> { new User(), new Guardian() });
            Activity a1 = new Activity(new List<IObserver> { new User()});

            a1.Name = "Lanzamiento de CEIS";

            Console.ReadLine();
        }
    }
}
