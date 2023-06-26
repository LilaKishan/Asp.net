using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{

    class Addition
    {
        int ta;
        int da;
        int hda;


        Addition(int ta, int da, int hda)
        {
            this.ta = ta;
            this.da = da;
            this.hda = hda;

        }

        static void Main(string[] args)
        {
            int salary;

            Addition p = new Addition(10, 20, 30);
            salary = p.ta + p.da + p.hda;
            Console.WriteLine("Salary  : " + salary);


        }



    }
}

    

