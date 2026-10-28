using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSLearning
{
    abstract class Abstract
    {
        public int AddNumb(int a,int b)
        {
            return a + b;
        }
        public abstract int multinumb(int a,int b);
    }
    class Derived:Abstract
    {
        public override int multinumb(int a, int b)
        {
               return a * b;
        }
    }
}
