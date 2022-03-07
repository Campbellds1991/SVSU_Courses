package program07;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.Scanner;
/* 	Filename: Program07
 * 
 * 	Author:	Devin Campbell
 *  Class: 	CS116-02-MW
 * 
 *	Program Description: Reads file, sorts numbers, then displays numbers divisible by 3 
 *						
 */
public class Program07 {
	public static void main(String[] Args) throws IOException, FileNotFoundException{
		Scanner input = new Scanner(new File("input.data"));
		// finds the length of the file
		long LineCount = Files.lines(Paths.get("input.data")).count();
		int Arr[] = new int[(int)LineCount];
		for(int i = 0; input.hasNext(); i++){
			Arr[i] = input.nextInt();
		}
		input.close();
		// Bubble sort function returns a sorted 1d array
		Arr = BubbleSort(Arr);
		for(int i = 0; i < Arr.length ; i++){
			if(Arr[i] % 3 == 0) System.out.println(Arr[i] + " is divisible by 3");
		}
	}
	 public static int[] BubbleSort(int[] arr){
	        int temp;
	        for(int i=0; i < arr.length-1; i++){	 
	            for(int j=1; j < arr.length-i; j++){
	                if(arr[j-1] > arr[j]){
	                    temp=arr[j-1];
	                    arr[j-1] = arr[j];
	                    arr[j] = temp;
	                }
	            }
	        }
	        return arr;
	 }
}
