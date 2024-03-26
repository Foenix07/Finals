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
        //a new dictionary
        Dictionary<string, Bank_acc> bankaccounts = new Dictionary<string, Bank_acc>();
        Random number = new Random();
        public void MakeAcc()
        {
            Console.WriteLine("This is going to be your new bank account, please give us all of the requested information.");
            
            //type of account (enum)
            Console.WriteLine("Which type of bank account are you interested in signing up for? Please enter a number assigned to the option. \n1 - Normal accoount\n2 - Kid's account\n3 - Saving account");
            string accType = Console.ReadLine();
            
            //account ID
            string accID = Convert.ToString( Convert.ToInt32(accType) + (1001 + bankaccounts.Count()));
            
            //bank account number
            Console.Write("AccNumber: ");
            string accNumber = Console.ReadLine();
          
            //full name of the accoount holder
            Console.Write("Your full name: ");
            string holder = Console.ReadLine();

            //holder age
            Console.Write("When were you born? (DD/MM/YYYY): ");
            int holderAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("HolderParentalControl: ");
            bool holderParentalControl = Convert.ToBoolean(Console.ReadLine());

            Console.Write("holdermail: ");
            string holderEmail = Console.ReadLine();

            Console.Write("password: ");
            string password = Console.ReadLine();

            Console.Write("holderphone: ");
            string holderPhone = Console.ReadLine();

            Console.Write("balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("loan: ");
            double loan = Convert.ToDouble(Console.ReadLine());

            Console.Write("loaninterestrate: ");
            double loanInterestRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("dailyLimit: ");
            double dailyLimit = Convert.ToDouble(Console.ReadLine());

            Bank_acc item = new Bank_acc(accID, accNumber, holder, holderAge, holderParentalControl, holderEmail, password, holderPhone, balance, loan, loanInterestRate, dailyLimit, Convert.ToInt32(accType));
            bankaccounts.Add(accID, item);

            Bank_acc.GetThingies(bankaccounts[accID]);
        }

    }
}
