/* Assignment: Homework 1 - Problem #1
 * Name: Devin Campbell
 * Class: CS-216-02
 * Semester Fall 2016
 * Student ID: Dscampbe | 604149
 * 
 * Program: 
 * 	counts the number of times a number occurs in the users input	
 * 
 * 		Input: User input - Multiple numbers between 1 and 100 then 0 to exit
 * 		Process: build array, iterate index values for each number, then determine 
 * 			indexes with 1 or more occurrence.
 * 		Output: number of occurrences for each number entered
 */

import java.util.*;

public class problem01 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Enter the integers between 1 and 100: ");
		
		// Created array to hold all possibilities between 1 and 100 with number of occurrences
		int[] numList = new int[100];
		int num;
		do{
			num = input.nextInt();
			if (num != 0){
				// counts occurrences based on index
				numList[num-1]++;
			}
		}while(num != 0);
		// Checks all array locations in order from small to largest
		for(int i=0;i<100;i++){
			// Displays locations that have at least 1 occurrence
			if(numList[i]!=0){
				// Grammatical check
				if(numList[i]>1){
					System.out.println(String.format("%1$d occurs %2$d times.", i+1, numList[i]));
				}else{
					System.out.println(String.format("%1$d occurs %2$d time.", i+1, numList[i]));
				}
			}
		}
		input.close();
		
	}
}
