/* Assignment: Homework 1 - Problem #4
 * Name: Devin Campbell
 * Class: CS-216-02
 * Semester Fall 2016
 * Student ID: Dscampbe | 604149
 * 
 * Program: 
 * 	User to input letter grade, program determines value from letter grade,
 * 	then outputs numerical value	
 * 
 * 		Input: User input - single character
 * 		Process: convert letter to number 
 * 		Output: 
 * 			1) Grade point based on letter grade
 */
import java.util.*;

public class problem04 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Not Case Sensitive. Enter Exit to end program");
		String out =  "";
		// can use boolean "true" however all code following would be unreachable
		while(out != "exit"){
			System.out.print("Enter a letter grade: ");
			// Prevents unnecessary white space
			String grade = input.next().trim();
			// Prevents program from being case-sensitive
			// Check all possibilities - loop until asked to exit
			switch(grade.toUpperCase()){
			case "A":
				out = "4";
				break;
			case "B":
				out = "3";
				break;
			case "C":
				out = "2";
				break;
			case "D":
				out = "1";
				break;
			case "F":
				out = "0";
				break;
			case "EXIT":
				System.exit(0);				
			default:
				System.out.println(grade + " is an invalid grade");
				System.out.println();
				continue;
			}
			// prints statement only if switch statement completes
			System.out.println("The numeric value for grade " + grade + " is " + out);
			System.out.println();
		}
		input.close();
	}
}
