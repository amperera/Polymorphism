using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Employee
    {
        protected string st = "This class is";
        public virtual string Printthis()
        {
            return(st + " , " + "base");
        }
    }
    public class FultimeEmployee : Employee
    {
        public override string Printthis()
        {
            return(st + " , " + "FultimeSub");
        }
    }
    public class PartTimeEmployee : Employee
    {
        public override string Printthis()
        {
            return(st + " , " + "ParttimeSub");
        }
    }

    [TestFixture]
    class TestClass
    {
        [Test]
        public void TestPoly()
        {
            Employee[] employee = new Employee[2];
            employee[0] = new FultimeEmployee();
            employee[1] = new PartTimeEmployee();

            foreach (var emp in employee)
            {
                Assert.AreNotEqual("This class is base ", emp.Printthis());

            }
        }

        
    }


}
