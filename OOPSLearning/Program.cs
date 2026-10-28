using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OOPSLearning
{
    internal class Program
    {
        //static int b = 20;  // it will create a M/R automatically only once , value will be maintaining throug out the application
        static void Main(string[] args)
        {



            ConstructorDemo D1 = new ConstructorDemo(345, "IT", "ECE");
            D1.LatestObjectValues();
            ConstructorDemo D2 = new ConstructorDemo(456, "IT", "MECH");
            D2.LatestObjectValues();
            D2._id = 457;
            D2.LatestObjectValues();

            BaseClass B1 = new BaseClass();
            B1.Name = " Malli";
            B1.PrintMethod(); //virtual method called due to base class object

            //BaseClass B2 = new ChildClass();
            //B2.PrintMethod(); //overridden method called

            //ChildClass C2=new ChildClass();
            //ChildClass C3 = (ChildClass)B1;

            Derived D = new Derived();
            int added = D.AddNumb(10, 25);
            int multi = D.multinumb(10, 25);
            Console.WriteLine(multi + " " + added);


            Static.PrintEmp("vaishu");

            string nameemp = Static.nameofcomp;
            Static S = new Static();
            int numemp = S.numofempl;
            Console.WriteLine(nameemp);
            Console.WriteLine(numemp);
            try
            {
                int a = 10;
                int result = a / 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //AbstractObj abstractOb1j= new AbstractObj();


            AbstractObj abstractObj = new Child();
            //how to call abstract class constructor and purpose of abstract constructor




            //abstractObj.multiply(10, 20);

            D d = new D();
            IA a = (IA)d;
            a.Add(10, 20);



            Child C1 = (Child)abstractObj;

            //Child C1 = new Child();
            int adding = C1.add(5, 10);
            int multiplying = C1.multiply(5, 10);
            Console.WriteLine(multiplying + " " + adding);


            ClassObj C = new ClassObj();
            C.PrintStudent(5);


            ChildFruits CF = new ChildFruits();
            CF.AppleCount();
            CF.MangoCount();
          
            Fruits F2 = CF;
            F2.AppleCount();
            F2.MangoCount();

            //Calingg static methods 
            Fruits.DisplayCount();

            Console.ReadLine();
        }
    }
}
    