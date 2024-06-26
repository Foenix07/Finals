﻿using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalsproject
{
    //enum declaration
    enum AccTypeEnum
    {
        Bezny,
        Detsky,
        Sporici,
    }

    //class properties
    internal class Bank_acc
    {
        public string accID { get; set; }
        public string accNumber { get; set; }
        public string holder { get; set; }
        public int holderAge { get; set; }
        public string holderEmail { get; set; }
        public string password {  get; set; }
        public string holderPhone { get; set; }
        public double balance { get; set; }
        public double loan { get; set; }
        public double loanInterestRate { get; set; }
        public double dailyLimit { get; set; }
        public AccTypeEnum accType { get; set; }

       

        //constructor
        public Bank_acc(string AccID, string AccNumber, string Holder, int HolderAge, string HolderEmail, string Password, string HolderPhone, double Balance, double Loan, double LoanInterestRate, double DailyLimit, int AccType)
        {
            this.accID = AccID;
            this.accNumber = AccNumber;
            this.holder = Holder;
            this.holderAge = HolderAge;
            this.holderEmail = HolderEmail;
            this.password = Password;
            this.holderPhone = HolderPhone;
            this.balance = Balance;
            this.loan = Loan;
            this.loanInterestRate = LoanInterestRate;
            this.dailyLimit = DailyLimit;
            this.accType = (AccTypeEnum)AccType;
        }

        //a method to show info about each instance of the Bank_acc class
        public static void GetThingies(object writer)
        {
            Console.WriteLine("\n");
            foreach (var item in writer.GetType().GetProperties())
            {

                Console.Write(item.Name + ": ");
                Console.WriteLine(item.GetValue(writer));
            }
        }

        // - DONE add account(holder, age, mail, phone, password), set up limits and parental control - use accType

        //transfer money from one account to another through accNumber, use balance
        
        // - DONE get into an account (accID,), email/phone verification mby???

        // - DONE get info abt an acc w a password verification -> work with txt???

        // - DONE setting up, deducing loans

        //write out all purchases -> work with text

    }
}

