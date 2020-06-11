using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR2020_16_HomeWork_Banking
{
    public class BankAccount
    {
		List<double> DepositList = new List<double>();
		public string username { get; set; }
		public double Balance { get; set; }
		public BankAccount(string username, double Balance)
		{
			this.username = username;
			this.Balance = Balance;

			Console.WriteLine("Username: {0} , Balance: {1}", username, Balance);
			NextMenu();
		}
		public void NextMenu()
		{
			double balance = Balance;
			Console.WriteLine("Enter 1 for Withdrawl, 2 for Deposit, 3 for Logout, 4 for Deposit History");
			string StringMenu = Console.ReadLine();
			int NextChoice = Convert.ToInt32(StringMenu);
			switch (NextChoice)
			{
				case 1:
					Withdraw();
					break;
				case 2:
					Deposit();
					break;
				case 3:
					Logout();
					break;
				case 4:
					DepositHistory();
					break;
			}
		}

		public double Withdraw()
		{
			Console.WriteLine("Available Balance: {0}", Balance);
			Console.WriteLine("How much would you like to withdraw?: ");
			double WithdrawAmt = Convert.ToDouble(Console.ReadLine());
			Balance = Balance -= WithdrawAmt;
			Console.WriteLine(Balance);
			NextMenu();
			return WithdrawAmt;
		}

		public double Deposit()
		{
			Console.WriteLine("Your Available Balance: {0}", Balance);
			Console.WriteLine("How much would you like to deposit?: ");
			double DepositAmt = Convert.ToDouble(Console.ReadLine());


			DepositList.Add(DepositAmt);

			Balance = Balance + DepositAmt;
			Console.WriteLine(Balance);
			NextMenu();
			return DepositAmt;
		}

		public void Logout()
		{
			Console.WriteLine("Goodbye: " + username);
		}

		public void DepositHistory()
		{
			foreach (double i in DepositList)
			{
				Console.WriteLine("Deposit History: " + i);
			}
		}
	}
}
