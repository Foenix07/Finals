using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalsproject
{
    enum AccTypeEnum
    {
        Bezny,
        Detsky,
        Sporici,
    }

    internal class Bank_acc
    { 
        public string accID;
        public string accNumber;
        public string holder;
        public int holderAge;
        public bool holderParentalControl;
        public string holderEmail;
        public string password;
        public string holderPhone;
	    public double balance;
	    public double loan;
	    public double loanInterestRate;
	    public double dailyLimit;
        public string cardNumber;
        public int pin;
	    public AccTypeEnum accType;
	    
        public Bank_acc(string AccID, string AccNumber, string Holder, int HolderAge, bool HolderParentalControl, string HolderEmail, string Password, string HolderPhone, double Balance, double Loan, double LoanInterestRate, double DailyLimit, string CardNumber, int Pin, int AccType)
        {
            accID = AccID;
            accNumber = AccNumber;
            holder = Holder;
            holderAge = HolderAge;
            holderParentalControl = HolderParentalControl;
            holderEmail = HolderEmail;
            password = Password;
            holderPhone = HolderPhone;
            balance = Balance;
            loan = Loan;
            loanInterestRate = LoanInterestRate;
            dailyLimit = DailyLimit;
            cardNumber = CardNumber;
            pin = Pin;
            accType = (AccTypeEnum)AccType;
        }
        

    }
}

