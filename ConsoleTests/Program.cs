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
            sg.setScoutGroupData("123", "aguilas negras", "colombia", "cartagena", "olaya", "angel");
            Console.WriteLine(sg.ToString());
            sg.setScoutGroupData("456", "los rastrojos", "colombia", "cartagena", "pozon", "angel");
            Console.WriteLine(sg.ToString());
            Console.WriteLine("\nGroup name: " + sg.Name);
            sg.Name = "micaela";
            Console.WriteLine(sg.ToString());
            Console.ReadLine();

        }
    }
}
