/* Assignment: Homework 1 - Problem #2
 * Name: Devin Campbell
 * Class: CS-216-02
 * Semester Fall 2016
 * Student ID: Dscampbe | 604149
 * 
 * Program: 
 * 	Tests user input to find negative number, then shows positive value of number entered	
 * 
 * 		Input: User input - Integer Number
 * 		Process: test number for sign
 * 		Output: 
 * 			1) Valid or invalid
 * 			2) Number entered
 */

import java.util.Scanner;

public class problem02 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Enter a negative number: ");
		int num = input.nextInt();
		// Error check
		while(num>=0){
			System.out.print("The number you entered is invalid. Please enter a valid negative number: ");
			num=input.nextInt();			
		}
		// Displays result
		System.out.println(String.format("The number you entered is: %1$d",num*(-1)));
		input.close();
	}

}
