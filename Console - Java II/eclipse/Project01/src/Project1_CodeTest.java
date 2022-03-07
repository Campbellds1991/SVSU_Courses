import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;


public class Project1_CodeTest {

	public static void main(String[] args){
		IntegerLinkedList ILL = new IntegerLinkedList();
		GenericLinkedList<Integer> GLL = new GenericLinkedList<Integer>();
		IntegerArrayList IAL = new IntegerArrayList();
		GenericArrayList<Integer> GAL = new GenericArrayList<Integer>();
		
		//used to calculate sum and prove calc functions
		Calculator<Integer> calc = new Calculator<Integer>();
		
		System.out.println(calc.add(12, 12));
		System.out.println(calc.subtract(12, 12));
		System.out.println(calc.multiply(12, 12));
		System.out.println(calc.divide(12, 12));
		System.out.println(calc.average(12, 20));
		System.out.println();
		
		//File pointer and raw data for use
		File scores = new File("scores.txt");
		Integer[] scoresData = StartRead(scores);
		
		//Variables for Sum and AVG
		int ILL_Sum=0,GLL_Sum=0,IAL_Sum=0,GAL_Sum =0;
		
		
		for(int i = 0; i<scoresData.length;i++){
			ILL.add(scoresData[i]);
			ILL_Sum += ILL.get(i);
			GLL.add(scoresData[i]);			 
			GLL_Sum += GLL.get(i);
			IAL.add(scoresData[i]);			
			IAL_Sum += IAL.get(i);
			GAL.add(scoresData[i]);		
			GAL_Sum += GAL.get(i);				
		}
		System.out.println("Integer Linked List - SUM:"+ILL_Sum+" AVG:"+ILL_Sum/(double)ILL.length);
		System.out.println("Generic Linked List - SUM:"+GLL_Sum+" AVG:"+GLL_Sum/(double)GLL.length);
		System.out.println("Integer Array List  - SUM:"+IAL_Sum+" AVG:"+IAL_Sum/(double)IAL.getSize());
		System.out.println("Generic Array List  - SUM:"+GAL_Sum+" AVG:"+GAL_Sum/(double)GAL.getSize());		
		
	}
	//pulls data out of file and returns array with required data
	public static Integer[] StartRead(File file){
		Scanner in;
		Integer[] out = new Integer[6];
		try {
			in = new Scanner(file);
			int i = 0;
			while(in.hasNextLine()){
				out[i++] = in.nextInt();				
			}
			in.close();
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		}
		
		
		return out;
	}
}
