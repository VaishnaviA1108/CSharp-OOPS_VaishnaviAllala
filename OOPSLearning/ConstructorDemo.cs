using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSLearning
{
    internal class ConstructorDemo
    {
        public int _id = 123;
        public string _branch = "IT";
        public string _department = "CSE";
        public ConstructorDemo()
        {

        }
        public ConstructorDemo(int id,string branch)
        {

        }
        public ConstructorDemo(int id,string branch,string department)
        {
            _id = id;
            _branch = branch;
            _department = department;
        }
        public void LatestObjectValues()
        {
            Console.WriteLine(String.Format("MyValues {0} {1}",_id,_branch,_department));
        }
    }
}
