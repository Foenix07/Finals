using System;
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
            string acctype = Console.ReadLine();
            Bank_acc bankacc1 = new Bank_acc("ahoj", "1234567", "Dani", 18, true, "d.d@gmail.com", "password", "12345678", 1098.345, 12345.345678, 5.7, 50000, AccType: int.Parse(acctype));
            Console.WriteLine(bankacc1.accType);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            
        }
    }
}
