using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSLearning
{
    public class Fruits
    {
        public void AppleCount()
        {
            Console.WriteLine("Number of apples counted");
        }
        public virtual void MangoCount()
        {
            Console.WriteLine("Number of mangoes counted");
        }
        public static void DisplayCount()
        {
            Console.WriteLine("Displaying fruits count");
        }

    }
    public class ChildFruits : Fruits
    {
        public override void MangoCount()
        {
            Console.WriteLine("Number of mangoes counted");
        }

    }

    public interface IA
    {
        int Add(int x, int y);

        //int  Mul (int x, int y);
    }

    public class A : IA
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }

    public interface IB
    {
        int Add(int x, int y);
    }

    public class B : IB
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }


    //public class C
    //{
    //    public int Add(int x, int y)
    //    {
    //        return x + y;
    //    }
    //}

    public class D :IA, IB
    {
        public int Div(int x, int y)
        {
            return x + y;
        }

        int IA.Add(int x, int y)
        {
            return x + y;
        }

        int IB.Add(int x, int y)
        {
            return x + y;
        }
    }
}

