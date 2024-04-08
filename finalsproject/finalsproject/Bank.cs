using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace finalsproject
{
    public class Bank
    {
        //for acc ID so that it doesnt get messed up when removing from dict
        int existentBankaccountsCount = 0;
        
        //a new dictionary
        Dictionary<string, Bank_acc> bankaccounts = new Dictionary<string, Bank_acc>();
        
        
        public void MakeAcc()
        {
            existentBankaccountsCount += 1;

            Console.WriteLine("This is going to be your new bank account, please give us all of the requested information.");
            
                //type of account (enum)
            Console.WriteLine("Which type of bank account are you interested in signing up for? Please enter a number assigned to the option. \n1 - Normal accoount\n2 - Kid's account\n3 - Saving account");
            string accType = Console.ReadLine();
                //account ID
            string accID = Convert.ToString(Convert.ToInt32(accType) + Convert.ToString(1001 + existentBankaccountsCount));
                //bank account number
            Console.Write("AccNumber: ");
            string accNumber = Console.ReadLine();
                //full name of the account holder
            Console.Write("Your full name: ");
            string holder = Console.ReadLine();
                //holder age
            Console.Write("Holder's age: ");
            int holderAge = Convert.ToInt32(Console.ReadLine());
                //parental control
            bool holderParentalControl;
            if (holderAge >= 18)
                {
                    holderParentalControl = false;
                }
            else
                {
                    holderParentalControl = true;
                }
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
            Bank_acc item = new Bank_acc(accID, accNumber, holder, holderAge, holderParentalControl, holderEmail, password, holderPhone, balance, loan, loanInterestRate, dailyLimit, Convert.ToInt32(accType));
            bankaccounts.Add(accID, item);

            Bank_acc.GetThingies(bankaccounts[accID]);
        }

        public void SignIn()
        {
            bool signedIn = false; 
            while (signedIn == false)
            {
                Console.Write("\nYour account ID: ");
                string signInID = Console.ReadLine();


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

                else
                {
                    Console.Write("An account with this ID does not exist.");
                }
            }
            
        }
    }
}
