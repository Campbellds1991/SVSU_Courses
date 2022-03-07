package ex17_02;
import java.io.*;
/* Assignment: Homework 4
 * Name: Devin Campbell
 * Class: CS-216-02
 * Semester Fall 2016
 * Student ID: Dscampbe | 604149
 */
public class BuildBinaryFile
{
	public static void main(String[] Args)
	{
		// create pointer and datastream
		File file = new File("Exercise17_02.dat");
		DataOutputStream pWrite = null;
		
		//check for existing file
		if(file.exists())
		{
			System.out.println("File Exists, Ending process.");
			System.exit(-1);
		}
		else
		{
			try
			{
				pWrite = new DataOutputStream(new FileOutputStream(file));
				for(int i = 0; i < 100; i++)
				{
					//100 random integers
					int temp = (int) (Math.random()*Integer.MAX_VALUE);
					pWrite.writeInt(temp);
				}
				pWrite.close();
				DataInputStream read = new DataInputStream(new FileInputStream(file));
				
				//using eof exception to end loop
				while(true){
					System.out.println(read.readInt());
				}
				
				
			}
			catch(FileNotFoundException e)
			{
				System.out.print("File was failed to be reached.");
				System.exit(-1);
			}
			catch(EOFException e)
			{
				
			}
			catch(IOException e)
			{
				e.printStackTrace();
			}
		}
	}
	
}

