/* Assignment: Homework 2 - Test Program
 * Name: Devin Campbell
 * Class: CS-216-02
 * Semester Fall 2016
 * Student ID: Dscampbe | 604149
 * 
 * Program: 
 * 	Creates a test account to test methods and constructors	
 * 
 * 		Input: No input
 * 		Process: 
 *			p1) Create first account and set balance to 20,000
 *			p2) Withdraw and deposit using built-in methods
 *			p3) Create array of BankAccount objects
 *			p4) Initialize 3 accounts with a balance of 500 each
 * 		Output: 
 * 			o1) Display variables for first account
 * 			o2) Display variables for 3 identical accounts
 */

public class TestBank {

	public static void main(String[] args) {
		
		//p1) Create first account and set balance to 20,000 
		BankAccount acct1 = new BankAccount(20000);
		
		// p2) Withdraw and deposit using built-in methods
		acct1.withdraw(2500);
		acct1.deposit(3000);
		
		// o1) Display variables for first account
		System.out.printf("Account Number: %08d | Balance: $%,.2f \n" ,acct1.getAccountNum(), acct1.getBalance());
		
		// p3) Create array of BankAccount objects
		// p4) Initialize 3 accounts with a balance of 500 each
		BankAccount[] trialAccts = BankAccount.starterAccounts(10,500);
		
		// o2) Display variables for 3 identical accounts
		for(BankAccount i: trialAccts){
			System.out.printf("Account Number: %08d | Balance: $%,.2f \n",i.getAccountNum(), i.getBalance());
		}
		
		
	}

}
