using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
       
       class Student
        {
            public double Enrollment_no;
            public String student_name;
            public int semester;
            public double cpi;
            public double spi;

            static void Main(string[] args)
            {

                Student p = new Program();
                p.getData();
                p.displayData();

            }

            public void getData()
            {
                Console.WriteLine("Enter Enrollment_no");
                Enrollment_no = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter student_name");
                student_name = Console.ReadLine();
                Console.WriteLine("Enter semester");
                semester = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter cpi");
                cpi = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter spi");
                spi = Convert.ToDouble(Console.ReadLine());

            }
            public void displayData()
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine(Enrollment_no);
                Console.WriteLine(student_name);
                Console.WriteLine(semester);
                Console.WriteLine(cpi);
                Console.WriteLine(spi);
            }
        }

    }

    

