package ex12_14;

import java.io.*;
import java.util.Scanner;
/* Assignment: Homework 4
 * Name: Devin Campbell
 * Class: CS-216-02
 * Semester Fall 2016
 * Student ID: Dscampbe | 604149
 */
public class ScoresFromFile
{

	public static void main(String[] args)
	{
		//Point at file
		File file = new File("src\\ex12_14\\Scores.data");
		//declare objects and primitives required
		Scanner in = null;
		int total = 0, count = 0;
		double average = 0;
		
		//try to open file
		try
		{
			in = new Scanner(file);
		}
		catch (FileNotFoundException e)
		{
			System.out.println("File does not Exist");
			System.exit(-1);
		}
		
		//read all data in file and output total and average of scores
		while(in.hasNext()){
			int temp = in.nextInt();
			total += temp;
			count++;
		}
		average = total/(double)count;
		
		System.out.printf("Total: %d\nAverage: %.2f",total,average);
		
	}

}
