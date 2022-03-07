import java.text.DecimalFormat;
import java.util.Scanner;

public class EC_Exersice_9_10 {
    /* *******************************************************************
	 * filename     : EC_Exersice_9_10.java
	 * author       : Devin Campbell
	 * svsu id      : dscampbe
	 * course       : cs116 
	 * section      : 02-MW
	 * semester		: Winter 2016
	 *
     * description  : This program has a user input values from a quadratic equasion,
	 *				  determines if it has any solutions,
	 *				  then displays such results to the user.
	 *				  
	 *
     * input        : 3 doubles from user input
	 *				 
     * processing   : Steps in the program:
	 *      		  1. have user enter information
	 *      		  2. initiate QuadraticEquasion Object using data from user 
	 *      		  3. check if Equation has any solutions
	 *      		  	3a. Display Both roots to user or
	 *      			3b. Display to user that equation has no solutions
	 *      		  
     * output       : printed results of the quadratic equation    
	 *
     * precondition : None
	 *				  
     * postcondition: the screen will display the items determined in processing
	 *				  the Quadratic equation class
     * ******************************************************************* 
	 */
	
	
	public static void main(String[] args) {	
		double a,b,c;
		
		// initiate beginning Objects
		DecimalFormat Decimal = new DecimalFormat("#,###.00");
		Scanner sc = new Scanner(System.in);
		
		// have user enter information
		System.out.println("Quadratic Equation: Ax^2 + Bx + C");
		System.out.println("Enter A: ");
		a = sc.nextInt();
		System.out.println("Enter B: ");
		b = sc.nextInt();
		System.out.println("Enter C: ");
		c = sc.nextInt();
		//close scanner
		sc.close();
		// initiate QuadraticEquasion Object using data from user
		QuadraticEquasion QE = new QuadraticEquasion(a, b, c);
		// check if Equation has any solutions
		if(QE.getDiscriminant() >= 0){
			// Display Both roots to user
			System.out.println("Root1 = " + Decimal.format(QE.getRoot1()));
			System.out.println("Root2 = " + Decimal.format(QE.getRoot2()));
		}else{
			// Display to user that equation has no solutions
			System.out.println("The Equasion has no roots");
		}
	}
}
class QuadraticEquasion{
	double A;
	double B;
	double C;
		// Object Constructor
		QuadraticEquasion(double a,double b, double c){
			this.A = a;
			this.B = b;
			this.C = c;
		}
		// determines value inside the root
		public double getDiscriminant(){
			double Discriminant = 0;
				Discriminant = (Math.pow(B, 2) - (4 * A * C));
				return Discriminant;
		}
		// determines Left Root
		public double getRoot1(){
			double Root = 0;
			if (getDiscriminant() >= 0){
				Root = ((B*-1)-Math.sqrt(getDiscriminant()))/(2*A);
			}		
			return Root;
		}
		// determines right Root
		public double getRoot2(){
			double Root = 0;
			if (getDiscriminant() >= 0){
				Root = ((B*-1)+Math.sqrt(getDiscriminant()))/(2*A);
			}
			return Root;
		}
}

