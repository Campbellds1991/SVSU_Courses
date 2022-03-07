/* Assignment: Homework 2 - BankAccount Class
 * Name: Devin Campbell
 * Class: CS-216-02
 * Semester Fall 2016
 * Student ID: Dscampbe | 604149
 * 
 * Program: 
 * 	Creates a class on which an object can be created. Requires
 * 		items to be called from outside of the class.
 */
public class BankAccount {
	private static int newAccountNum = 1;
	private int accountNumber;
	private double balance;
	// Default Constructor
	BankAccount(){
		accountNumber = newAccountNum++;
		balance = 0;
	}
	// overloaded constructor with designated starting balance
	BankAccount(double startBalance){
		accountNumber = newAccountNum++;
		balance = startBalance;
	}
	// initializes a BankAccount Array with x number of accounts with the default 500 start balance
	static BankAccount[] starterAccounts(int numOfAccounts){
		
		BankAccount[] outArray = new BankAccount[numOfAccounts];
		for(int i = 0; i < outArray.length; i++){
			outArray[i] = new BankAccount(500);
		}
		return outArray;
	}
	// overloaded method to use an ObjectArray and set all locations to the default balance
	static BankAccount[] starterAccounts(BankAccount[] acctArray){
		
		int numOfAccounts = acctArray.length;
		BankAccount[] outArray = new BankAccount[numOfAccounts];
		for(int i = 0; i < outArray.length; i++){
			outArray[i] = new BankAccount(500);
		}
		return outArray;
	}
	// overloaded method using x number of accounts with a specified balance
	static BankAccount[] starterAccounts(int numOfAccounts, double startingBalance){
		
		BankAccount[] outArray = new BankAccount[numOfAccounts];
		for(int i = 0; i < outArray.length; i++){
			outArray[i] = new BankAccount(startingBalance);
		}
		return outArray;		
	}
	// overloaded method using an ObjectArray to set all locations to specified balance
	static BankAccount[] starterAccounts(BankAccount[] acctArray, double startingBalance){
		
		int numOfAccounts = acctArray.length;
		BankAccount[] outArray = new BankAccount[numOfAccounts];
		for(int i = 0; i < outArray.length; i++){
			outArray[i] = new BankAccount(startingBalance);
		}
		return outArray;
	}
	// Getters and Setters
	int getAccountNum(){
		return accountNumber;
	}
	public double getBalance(){
		return balance;
	}
	void setBalance(double newBalance){
		balance = newBalance;
	}
	// End Getters and Setters
	
	// Balance access methods
	public void withdraw(double withdrawlAmount){
		balance -= withdrawlAmount;
	}
	public void deposit(double depositAmount){
		balance += depositAmount;
	}

}
