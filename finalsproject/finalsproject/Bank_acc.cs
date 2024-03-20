﻿using System;
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
	    public AccTypeEnum accType;
	    
        public Bank_acc(string AccID, string AccNumber, string Holder, int HolderAge, bool HolderParentalControl, string HolderEmail, string Password, string HolderPhone, double Balance, double Loan, double LoanInterestRate, double DailyLimit, int AccType)
        {
            this.accID = AccID;
            this.accNumber = AccNumber;
            this.holder = Holder;
            this.holderAge = HolderAge;
            this.holderParentalControl = HolderParentalControl;
            this.holderEmail = HolderEmail;
            this.password = Password;
            this.holderPhone = HolderPhone;
            this.balance = Balance;
            this.loan = Loan;
            this.loanInterestRate = LoanInterestRate;
            this.dailyLimit = DailyLimit;
            this.accType = (AccTypeEnum)AccType;
        }

        //add account (holder, age, mail, phone, password), set up limits and parental control - use accType

        //transfer money from one account to another through accNumber, use balance
        
        //get into an account (accID,), email/phone verification mby???

        //get info abt an acc w a password verification -> work with txt???

        //setting up, deducing loans

    }
}

