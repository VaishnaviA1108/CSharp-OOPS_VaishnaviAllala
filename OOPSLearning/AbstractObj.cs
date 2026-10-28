using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOPSLearning
{
    abstract class AbstractObj
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public abstract int multiply(int x, int y);

        public AbstractObj()
        {
            Console.WriteLine("Abstract Class Called...");
        }

    }
    class Child : AbstractObj
    {

        public Child()
        {

        }
        public override int multiply(int x, int y)
        {
            return x * y;
        }
    }
}
