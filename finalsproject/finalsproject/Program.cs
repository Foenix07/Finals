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
            int signedChoice;
            do
            {
                Console.WriteLine("\nWant to make an account?\n1)Sign up for a new account\nAlready have an account?\n2)Sign into your account\n5)Exit");

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
                            do
                            {
                                Console.WriteLine("\nWhat would you like to do now?\n1)Edit account info\n2)Borrow money\n3)Transfer money\n4)Get info about my account\n5)Sign out and exit");
                                signedChoice = Convert.ToInt32(Console.ReadLine());
                                switch (signedChoice)
                                {
                                    case 1:
                                        banka.EditInfo();
                                        break;

                                    case 2:
                                        banka.BorrowMoney();
                                        break;

                                    case 3:
                                        banka.TransferMoney();
                                        break;

                                    case 4:
                                        banka.GetInfoButSignedIn();
                                        break;
                                    case 5:
                                        break;

                                    default:
                                        Console.WriteLine("Put in valid choice pls.");
                                        break;
                                }
                            } while (signedChoice != 5);
                        }
                        break;
                    case 3:
                        break;
                    
                    default:
                        Console.WriteLine("Put in valid choice pls.");
                        break;
                }
            } while (choice != 3);
            Console.ReadKey();          

            
        }
    }
}

