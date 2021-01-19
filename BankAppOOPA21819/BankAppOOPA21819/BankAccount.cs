/*
 * Created by SharpDevelop.
 * User: Raymond McCarthy
 * Date: 25/01/2019
 * Time: 12:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BankAccount
{
	/// <summary>
	/// Description of BankAccount.
	/// </summary>
	public class BankAccount
	{
		//private member fields
		private int account_no;
		private double balance, interestRate, interestEarned;
		
		//deposit method
		public void Deposit(double deposit){
			balance = balance + deposit;
		}
		
		//withdrawal method
		public void Withdrawal(double withdraw){
			if((balance>10) && (balance>=withdraw)){
				balance = balance - withdraw;
			}
			else{
				Console.WriteLine("Your funds are too low to withdarw");
			}
		}
		
		public void setInterest(double interest){
			interestRate = interest;
		}
		
		//method to apply interest rate
		public void applyInterest(){
			interestEarned = balance*interestRate;
		}
		
		public double getBalance(){			
			return balance;
		}
		
		public double getInterest(){
			return interestEarned;
		}
		
		//method to print bank report 1
		public void Header1(){
			Console.WriteLine("--------------------------------------------------------");
			Console.WriteLine("\tBANK REPORT 1");
			Console.WriteLine("\t\t\tClosing"+"\t\tInterest");
			Console.WriteLine("Account No:" + "\t\tBalance:" + "\tEarned:");
			Console.WriteLine("--------------------------------------------------------");
		}
		
		//method to print bank report 2
		public void Header2(){
			Console.WriteLine("\n--------------------------------------------------------");
			Console.WriteLine("\tBANK REPORT 2");
			Console.WriteLine("\t\t\tClosing"+"\t\tInterest");
			Console.WriteLine("Account No:"+"\t\tBalance: "+"\tEarned");
			Console.WriteLine("--------------------------------------------------------");
		}
		
		//method to print account details
		public void BankReport(){
			Console.WriteLine(account_no+ "\t\t" + balance + "\t\t" + interestEarned);
		}
		
		public BankAccount()
		{
		}
		
		//overloaded constructor
		public BankAccount(int acc, double bal){
			account_no = acc;
			balance = bal*1.1;
		}
	}
}