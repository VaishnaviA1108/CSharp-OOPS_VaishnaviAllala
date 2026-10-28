using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Inherit
    {
        public void Student()
        {
            Console.WriteLine(10);
        }
    }
    class Child : Inherit
    {
        public void Student1()
        {
            Console.WriteLine(20);
        }
    }
    class Child1: Inherit
    {
        public void Student2()
        {
            Console.WriteLine(30);
        }
    }
}
