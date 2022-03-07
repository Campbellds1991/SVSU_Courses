
	/* *******************************************************************
	 * filename     : Program10.java
	 * author       : Devin Campbell
	 * svsu id      : dscampbe
	 * course       : CS116 
	 * section      : 02-MW
	 * semester		: Winter 2016
	 *
     * description  : This program has a user input their current taxable income
	 *				  	and filing Status, calculates their total taxes for the year
	 *				  	then displays the total taxes owed back to the user
	 *
     * input        : 1 integer as the filing status & 1 double as users taxable income
	 *				 
     * processing   : Steps in the program:
	 *      		  1. have user enter information using scanner
	 *      		  2. Initiate Tax Object using data from user
	 *      		  3. Ask user for input, pass input to  variables
	 *      		  3a. Display Both roots to user or
	 *      		  3b. Display to user that equation has no solutions
	 *      		  
     * output       : printed results of the taxes due    
	 *
     * precondition : input Taxable income and Filing Status
	 *				  
     * postcondition: Display Taxes due
	 *				  
     * ******************************************************************* 
	 */
import java.text.DecimalFormat;
import java.util.Scanner;

public class program10 {
	public static void main(String[] args) {
		
	// Decimal formating for outputting data
	DecimalFormat Decimal = new DecimalFormat("#,###.00");
	
	// initiate Tax Object
	Tax tx = new Tax();
	// initiate Scanner Object
	Scanner sc = new Scanner(System.in);
	
	// Ask user for input, pass input to  variables
	System.out.print("Enter your Filing Status Index: ");
	tx.setFilingStatus(sc.nextInt());
	System.out.println();
	System.out.print("Enter your year's end taxable income: ");
	tx.setTaxableIncome(sc.nextDouble());
	
	// close Scanner
	sc.close();
	
	// Display results of tax object
	System.out.println();
	System.out.print("Year's Total Taxes: ");
	System.out.println(Decimal.format(tx.getTax()));
	}
}
class Tax{
	public static final int SINGLE_FILER = 0;
	public static final int MARRIED_JOINTLY = 1;
	public static final int MARRIED_SEPERATELY = 2;
	public static final int HEAD_OF_HOUSEHOLD = 3;
		
	private int filingStatus;
	private double taxableIncome;
	public static int [][] brackets = {
		{27050, 45200, 22600, 36250},
		{65550,109250,54625,93650},
		{136750,166500,83250,151650},
		{297350,297350,148675,297350},
		{Integer.MAX_VALUE,Integer.MAX_VALUE,Integer.MAX_VALUE,Integer.MAX_VALUE}};
	public static double [] rates = {0.15,0.275,0.305,0.355,0.391};
	
	// sets FilingStatus
	public void setFilingStatus(int status){
		this.filingStatus = status;
	}
	// returns FilingStatus
	public int getFilingStatus(){		
		return this.filingStatus;
	}
	// set TaxableIncome
	public void setTaxableIncome(double income){
		this.taxableIncome = income;
	}
	// returns TaxableIncome
	public double getTaxableIncome(){		
		return this.taxableIncome;
	}	
	// No-Arg constructor
	Tax(){}
	Tax(int filingStatus, int[][] brackets, double rates,double taxableIncome){
		this.filingStatus = filingStatus;
		this.taxableIncome = taxableIncome;		
	}
	// determines year ends tax
	public double getTax(){
		// set variables
		double Tax = 0;
		double temp = taxableIncome;
		double taxedIncome = 0;
		int i = 0;
		// goes thru the loop while it computes brackets below top bracket
		while(taxableIncome > brackets[i][filingStatus]){
			// increments Taxes due by taxing each bracket segment individually
			Tax += (brackets[i][filingStatus]-taxedIncome)*rates[i];
			// holds the value of taxable income already taxed
			taxedIncome += brackets[i][filingStatus];
			// Decrements a temporary value holding the remaining income to be taxed
			temp -= brackets[i][filingStatus];
			i++;
		}
		// Taxes the remaining income in the highest bracket
		Tax += temp * rates[i];
		// returns Taxes Due where called
		return Tax;
	}
	
}
