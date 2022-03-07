package ex12_15;
import java.io.*;
import java.util.Scanner;
/* Assignment: Homework 4
 * Name: Devin Campbell
 * Class: CS-216-02
 * Semester Fall 2016
 * Student ID: Dscampbe | 604149
 */
public class LoadAFile
{
	public static void main(String[] Args)
	{
		//create file pointer and create writer variable
		File file = new File("Exercise12_15.txt");
		PrintWriter pWrite = null;
		// check for existing file
		if(file.exists())
		{
			System.out.println("File Exists, Ending process.");
			System.exit(-1);
		}
		else
		{
			try
			{
				// try to open file
				pWrite = new PrintWriter(file);
				// write 100 integers to file
				for(int i = 0; i < 100; i++)
				{
					int temp = (int) (Math.random()*Integer.MAX_VALUE);
					pWrite.write(Integer.toString(temp)+"\n");
				}
				//close file so you can read it
				pWrite.close();
				// read data from file
				Scanner read = new Scanner(file);
				while(read.hasNext()){
					System.out.println(read.next());
				}
				read.close();
			}
			catch(IOException e)
			{
				System.out.print("File was failed to be reached.");
				System.exit(-1);
			}	
		}
	}
	
}
