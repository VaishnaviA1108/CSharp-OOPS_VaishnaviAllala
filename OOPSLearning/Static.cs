using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSLearning
{
    internal class Static
    {
        public int numofempl = 10;
        public static string nameofcomp = "IBM";
        public static void PrintEmp(string name)
        {
            Console.WriteLine("Static method called");
        }
        
    }
}
