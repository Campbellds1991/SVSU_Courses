package program05;

/* 	Filename: Program05
 * 
 * 	Author:	Devin Campbell
 *  Class: 	CS116-02-MW
 * 
 *	Program Description: Check names or addresses against file, then prints 
 *						the resulting lines from the test statement
 */

import java.io.*;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.*;

public class program05 {
	static String[][] Arr;
	public static void main(String[] args)throws IOException {
		Initailize();
		Process();
		
	}
// initialize the array in which you are going to test against
	public static void Initailize()throws IOException{
		try{
		File file = new File("people.program05");
		FileReader in = new FileReader(file);
		in.close();
		}catch(FileNotFoundException FNFE){
			System.out.println("File was not found.  Please place record file in same "
					+ "directory as this program\n"+"If using Eclipse, "
							+ "place file in the root of the working directory\n"+"\n");
			System.out.println(FNFE);
		}
		long LineCount = Files.lines(Paths.get("people.program05")).count();
		File file = new File("people.program05");
		FileReader in = new FileReader(file);
		
	// Going Letter by Letter, segment the file into a multi-dimensional array
		Arr = new String [(int) LineCount][5];
		int c;
		String word = "";
		for(int i = 0; i < LineCount; i++){
			for(int j = 0; j < 5; j++){
				while((c = in.read()) != -1){
					// tests for return chars, spaces, and other formatting commands
					if(c == 13){
						c = in.read();
					}
					if(c == 32 || c == 10){
						break;
					}else{
						word += (char)c;
					}
				}
				if(! word.equals("")){
					Arr[i][j] = word;
					word = "";
					}
				}
				
			}
				in.close();
	}
	public static void Process(){
		Scanner input = new Scanner(System.in);
		System.out.print("Enter query");
		String Arg1 = input.next();
		String Arg2 = "";
		String Arg3 = null;
		Boolean isAddress = null;
		Boolean isMatch = null;
		
		// check first test argument to find out if it is an address or name
		if(isNumeric(Arg1)){
			isAddress = true;
			Arg2 = input.next();
			Arg3 = input.next();
		}else{
			isAddress = false;
			Arg2 = input.next();
		}
		// Tests the argument and prints any line matching our test
		for(int i = 0; i < Arr.length; i++ ){
			for(int j = 0; j < Arr[i].length-2; j++){
				isMatch = false;
				if(Arr[i][j].equals(Arg1)){
					if(isAddress == true){
						if(Arr[i][j+1].equals(Arg2) && Arr[i][j+2].equals(Arg3))isMatch = true;
					}else{
						if(Arr[i][j+1].equals(Arg2))isMatch = true;
					}
				}
				if(isMatch == true){
					System.out.println(Arr[i][0]+" "+Arr[i][1]+" "+Arr[i][2]+" "+Arr[i][3]+" "+Arr[i][4]);
					
				}
			}
		}
		input.close();
	}
	
	// Tests to find if string is a numerical entity
	private static boolean isNumeric(String str) {  
		try{  
			Double.parseDouble(str);  
		}catch(NumberFormatException nfe){  
			return false;
		}
		return true;
		}
}


