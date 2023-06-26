using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
       
       class Bank_Deatil
        {
            public int account_no;
            public String username;
            public String email;
            public String account_type;
            public double account_balance;

            static void Main(string[] args)
            {

                Bank_Deatil p = new Bank_Deatil();
                p.getData();
                p.displayData();

            }

            public void getData()
            {
                Console.WriteLine("Enter account_no");
                account_no = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter username");
                username = Console.ReadLine();
                Console.WriteLine("Enter email");
                email = Console.ReadLine();
                Console.WriteLine("Enter account_type");
                account_type = Console.ReadLine();
                Console.WriteLine("Enter account_balance");
                account_balance = Convert.ToDouble(Console.ReadLine());

            }
            public void displayData()
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine(account_no);
                Console.WriteLine(username);
                Console.WriteLine(email);
                Console.WriteLine(account_type);
                Console.WriteLine(account_balance);
            }
        }

    }

    

