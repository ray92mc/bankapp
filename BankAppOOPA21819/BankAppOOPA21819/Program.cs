/*
 * Created by SharpDevelop.
 * User: Raymond McCarthy
 * Date: 25/01/2019
 * Time: 12:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;

namespace BankAccount
{
	class Program
	{
		public static void Main(string[] args)
		{
			//login with a for loop
			string user_id, pin;
			int loginAttempts = 0; //login attempts counter
			
			Console.WriteLine("Bank Account Login Screen");
			Console.WriteLine("=========================");
			
			//iteration three times
			for (int i=0; i<3; i++){
				Console.Write("\nEnter user ID: ");
				user_id = Console.ReadLine();
				Console.Write("Enter pin: ");
				pin = Console.ReadLine();
				
				if(user_id != "1234" || pin != "999")
				loginAttempts++; //increment login counter
				else
					break;
			}
				//display login result
				if (loginAttempts>2){
					Console.WriteLine("\nLogin failure!");
					System.Environment.Exit(0); //close program after 3 failed login attempts
				}
				else{
					Console.WriteLine("\nLogin successful!\n\n"); //end of login
				}
				
				int[] account_no = {80045001, 80045002, 80045003, 80045004};
				int[] initBalance = {100, 200, 300, 400};
				double[] deposit1 = {100, 200, 300, 400};
				double[] withdrawal1 = {50, 50, 50, 50};
				double[] deposit2 = {20, 200, 300, 400};
				double[] withdrawal2 = {255, 50, 50, 50};
				double[] interestRate = {0.01, 0.02, 0.03, 0.04};
		
				var reportHeader = new BankAccount();
				
				BankAccount[] customers = new BankAccount[4]; //initiates array of blank objects
				
				//initialise the array with a for loop, if true execute statments
				for(int i=0; i<customers.Length; i++){
					customers[i] = new BankAccount(account_no[i], initBalance[i]);
				}
				
				reportHeader.Header1();
				
				for (int i=0; i<customers.Length; i++){
					customers[i].Deposit(deposit1[i]);
					customers[i].Withdrawal(withdrawal1[i]);
					customers[i].setInterest(interestRate[i]);
					customers[i].applyInterest();
					customers[i].BankReport();
				}
				
				//summarise balance
				
				double totalBalance=0;
				double totalInterest=0;
				
				for(int i=0; i<customers.Length; i++){
					totalBalance = totalBalance + customers[i].getBalance();
				}
				for(int i=0; i<customers.Length; i++){
					totalInterest = totalInterest + customers[i].getInterest();
				}
				
				
				Console.WriteLine("--------------------------------------------------------");
				Console.WriteLine("Totals:"+"\t\t\t"+totalBalance + "\t\t" +totalInterest);
				Console.WriteLine("--------------------------------------------------------");
				
				//continue or exit
				Console.Write("\n\nWould you like to continue? Press Y or N: ");
				
				string temp = Console.ReadLine();
				if (temp == "Y" || temp == "y"){
					
					reportHeader.Header2();
					
					for (int i=0; i<customers.Length; i++){
						customers[i].Deposit(deposit2[i]);
						customers[i].Withdrawal(withdrawal2[i]);
						customers[i].setInterest(interestRate[i]);
						customers[i].applyInterest();
						customers[i].BankReport();
					}
					
				double totalBalance2=0;
				double totalInterest2=0;
					
				for(int i=0; i<customers.Length; i++){
					totalBalance2 = totalBalance2 + customers[i].getBalance();
				}
				
				for(int i=0; i<customers.Length; i++){
					totalInterest2 = totalInterest2 + customers[i].getInterest();
				}
				
					Console.WriteLine("--------------------------------------------------------");
					Console.WriteLine("Totals:" + "\t\t\t" +totalBalance2 + "\t\t" +totalInterest2);
					Console.WriteLine("--------------------------------------------------------");
				}
				else{
					Console.WriteLine("\nYou are now logged out!\n");
				}
				
				Console.Write("\nPress any key to close the program....");
				Console.ReadKey(true);
				
		}
	}
}