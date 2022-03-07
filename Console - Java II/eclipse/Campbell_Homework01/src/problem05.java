/* Assignment: Homework 1 - Problem #5
 * Name: Devin Campbell
 * Class: CS-216-02
 * Semester Fall 2016
 * Student ID: Dscampbe | 604149
 * 
 * Program: 
 * 	User inputs an string, then program outputs the character length of the string
 * 	and the first character of the string.	
 * 
 * 		Input: Line of Characters
 * 		Process: None
 * 		Output: 
 * 			1) Number of characters in String
 * 			2) First character of string
 */
import java.util.Scanner;

public class problem05 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Enter a String: ");
		// nextLine required to allow sentences
		String text = input.nextLine().trim();
		System.out.println();
		System.out.println("Number of characters: " + text.length());
		System.out.println("First character: " + text.charAt(0));
		input.close();
	}
}
