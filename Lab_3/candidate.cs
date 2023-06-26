using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
       
       class Program
        {
            public int c_id;
            public String c_name;
            public int c_age;
            public double c_weight;
            public double c_height;
            static void Main(string[] args)
            {

                Program p = new Program();
                p.getData();
                p.displayData();

            }

            public void getData()
            {
                Console.WriteLine("Enter Id");
               c_id= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
               c_name= Console.ReadLine();
                Console.WriteLine("Enter age");
                c_age=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter weight");
                c_weight=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter height");
               c_height= Convert.ToDouble(Console.ReadLine());

            }
            public void displayData()
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine(c_id);
                Console.WriteLine(c_name);
                Console.WriteLine(c_age);
                Console.WriteLine(c_height);
                Console.WriteLine(c_weight);
            }
        }

    }

    

