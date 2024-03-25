using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalsproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank banka = new Bank();
            banka.MakeAcc();
            Console.ReadKey();
            

            //máte už účet?? blabla bla pokud ano - jméno na které je účet napsán, pokud ne možnost vytvořit účet
        }
    }
}

