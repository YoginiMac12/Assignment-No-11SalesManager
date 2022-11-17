using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager("man1", 33000, 4000);
            m1.CalculateSalary();
            Console.WriteLine(m1);

            President p1 = new President("pres1", 31000, 4000);
            p1.CalculateSalary();
            Console.WriteLine(p1);


            SalesManager s1 = new SalesManager("sm1", 32000, 30000, 40000);
            s1.CalculateSalary();
            Console.WriteLine(s1);

        }
    }
}
