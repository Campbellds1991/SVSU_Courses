/* Assignment: Homework 1 - Problem #3
 * Name: Devin Campbell
 * Class: CS-216-02
 * Semester Fall 2016
 * Student ID: Dscampbe | 604149
 * 
 * Program: 
 * 	Random Number Generator - 0 to 2^32	
 * 
 * 		Input: None
 * 		Process: RNG 0 to Max integer value 
 * 		Output: Display Number
 */
public class problem03 {

	public static void main(String[] args) {
		// prints any possible integer variable randomly
		System.out.println((int) (Math.random()*Integer.MAX_VALUE));
	}
}
