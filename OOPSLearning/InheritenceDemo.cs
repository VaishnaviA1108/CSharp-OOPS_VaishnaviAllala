using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSLearning
{
    internal class BaseClass
    {

        //string _name = "";


        //public string Name
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    set
        //    {
        //        _name = value;
        //    }
        //}

       
        public string Name { get; set; }

        public void PrintBaseClass()
        {
            Console.WriteLine("Printbaseclass called");
        }
        public virtual void PrintMethod()
        {
            Console.WriteLine("virtual method called");
            Console.WriteLine(Name);
        }


        public static void StaticMethod()
        {
            Console.WriteLine("Static Method Called");
        }

    }
    class ChildClass : BaseClass
    {
        public void PrintChildClass()
        {
            Console.WriteLine("Printchildclass called");
        }
        public override void PrintMethod()
        {
            Console.WriteLine("overriden method called");
        }

    }

}
