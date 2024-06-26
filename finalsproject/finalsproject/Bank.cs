﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace finalsproject
{
    public class Bank
    {
        //for acc ID so that it doesnt get messed up when removing from dict
        int existentBankaccountsCount = 0;

        public string signInID = null;

        public bool signedIn;

        //a new dictionary
        Dictionary<string, Bank_acc> bankaccounts = new Dictionary<string, Bank_acc>();


        public void MakeAcc()
        {
            existentBankaccountsCount += 1;

            Console.WriteLine("This is going to be your new bank account, please give us all of the requested information.");

            //type of account (enum)
            Console.WriteLine("Which type of bank account are you interested in signing up for? Please enter a number assigned to the option. \n1 - Normal accoount\n2 - Kid's account\n3 - Saving account");
            string accType = Convert.ToString(Convert.ToInt32(Console.ReadLine()) - 1);
            
            //account ID
            string accID = Convert.ToString((Convert.ToInt32(accType) + 1) + Convert.ToString(1001 + existentBankaccountsCount));

            //full name of the account holder
            Console.Write("Your full name: ");
            string holder = Console.ReadLine();
            
            //holder age
            Console.Write("Holder's age: ");
            int holderAge = Convert.ToInt32(Console.ReadLine());
            
            //bank account number
            string accNumber = (Convert.ToString(Convert.ToInt32(accType) + 1) + Convert.ToString(100000000001 + existentBankaccountsCount) + "/7777");
            
            //holders mail
            Console.Write("Holder's e-mail: ");
            string holderEmail = Console.ReadLine();
            
            //holders phone num
            Console.Write("Holder's phone number: ");
            string holderPhone = Console.ReadLine();
            
            //password
            Console.Write("Set up a password: ");
            string password = Console.ReadLine();
            
            //balance of the account
            double balance = 0;
            
            //loan
            double loan = 0;
            
            //Interest rate
            double loanInterestRate = 8;
            
            //Daily limit
            double dailyLimit = 2000;

            //constructor call
            Bank_acc item = new Bank_acc(accID, accNumber, holder, holderAge, holderEmail, password, holderPhone, balance, loan, loanInterestRate, dailyLimit, Convert.ToInt32(accType));
            bankaccounts.Add(accID, item);

            Bank_acc.GetThingies(bankaccounts[accID]);
        }
        //method for signing in
        public void SignIn()
        {
            signedIn = false;
            while (signedIn == false)
            {
                Console.Write("\nYour account ID (If you wish to go back to log in page, press X): ");
                signInID = Console.ReadLine();


                if (bankaccounts.ContainsKey(signInID))
                {
                    Console.Write("Your password: ");
                    string signInPassword = Console.ReadLine();

                    if (bankaccounts[signInID].password == signInPassword)
                    {
                        Bank_acc.GetThingies(bankaccounts[signInID]);
                        signedIn = true;
                    }

                    else
                    {
                        Console.Write("Your password is invalid. Try again.");
                    }
                }

                else if (signInID.ToLower() == "x")
                {
                    break;
                }

                else
                {
                    Console.Write("An account with this ID does not exist.");
                }
            }

        }
        //method for editing info about an already created account
        public void EditInfo()
        {
            Console.WriteLine("Which information would you like to change?\n1)Name\n2)Phone number\n3)Email\n4)Password\n5)Daily limit\n6)Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (signInID != null)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("New name: ");
                        bankaccounts[signInID].holder = Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("New phone number: ");
                        bankaccounts[signInID].holderPhone = Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("New email: ");
                        bankaccounts[signInID].holderEmail = Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("New password: ");
                        bankaccounts[signInID].password = Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine("New daily limit: ");
                        bankaccounts[signInID].dailyLimit = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 6:
                        break;

                    default:
                        Console.WriteLine("Put in a valid coice pls.");
                        break;




                }

            }

        }

        public void BorrowMoney()
        {
            bool borrowed = false;
            do
            {
                Console.WriteLine("How much would you like to borrow? Please have in mind this is a 2 year loan, after this time there will be sanctions.: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (Convert.ToDouble(input) <= 500000.00)
                {
                    bankaccounts[signInID].balance = Convert.ToDouble(input);
                    bankaccounts[signInID].loan = (Convert.ToDouble(input) * (100 + bankaccounts[signInID].loanInterestRate)) / 100;
                    Console.WriteLine("Your monthly payment will be " + bankaccounts[signInID].loan / 24 + " starting next month.");
                    borrowed = true;
                }

                else
                {
                    Console.WriteLine("We cannot borrow this much money to you.");
                }
            } while (borrowed == false);

        }
        
        public void TransferMoney()
        {
            bool done = false;
            do
            {
                Console.WriteLine("What amount of money would you like to transfer?: ");
                double input = Convert.ToDouble(Console.ReadLine());
                if (input <= bankaccounts[signInID].balance)
                {
                    bankaccounts[signInID].balance = bankaccounts[signInID].balance - input;
                    
                    Console.WriteLine("What account would you like to transfer your money to?: ");
                    string input2 = Console.ReadLine();
                    foreach (string Key in bankaccounts.Keys)
                    {
                        if (bankaccounts[Key].accNumber == input2)
                        {
                            bankaccounts[Key].balance = bankaccounts[Key].balance + input;
                            done = true;
                        }
                        
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }

            } while (done == false);
        }

        public void GetInfoButSignedIn()
        {
            Bank_acc.GetThingies(bankaccounts[signInID]);
        }

        public Bank(bool _signedIn)
        {
            this.signedIn = _signedIn;

        }
 
    }

}
