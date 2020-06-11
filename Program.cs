using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR2020_16_HomeWork_Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = " ";
            Console.WriteLine("Enter username: ");
            username = Console.ReadLine();
            BankAccount newAccount = new BankAccount(username, 1700000);
        }
    }
}
