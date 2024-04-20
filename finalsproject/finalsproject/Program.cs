using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace finalsproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank banka = new Bank(false);
            int choice;
            do
            {
                Console.WriteLine("Want to make an account?\n1)Sign up for a new account\nAlready have an account?\n2)Sign into your account\n5)Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        banka.MakeAcc();
                        break;

                    case 2:
                        
                        banka.SignIn();
                        if (banka.signedIn == true)
                        {
                            Console.WriteLine("Do you want to make any changes?Y/N: ");
                            if (Console.ReadLine().ToLower() == "y")
                            {
                                banka.EditInfo();
                            }
                            
                        }
                        break;
                    case 3:
                        break;
                }
            } while (choice != 3);
            Console.ReadKey();          

            
        }
    }
}

