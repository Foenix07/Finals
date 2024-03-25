using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace finalsproject
{
    public class Bank
    {
        //a new dictionary
        Dictionary<string, Bank_acc> bankaccounts = new Dictionary<string, Bank_acc>();

        public void MakeAcc()
        {
            string acctype = Console.ReadLine();
            Bank_acc bankacc1 = new Bank_acc("ahoj", "1234567", "Dani", 18, true, "d.d@gmail.com", "password", "12345678", 1098.345, 12345.345678, 5.7, 50000, AccType: int.Parse(acctype));
            bankaccounts.Add(bankacc1.accID, bankacc1);
            bankacc1.GetThingies(bankaccounts[bankacc1.accID]);
        }

    }
}
