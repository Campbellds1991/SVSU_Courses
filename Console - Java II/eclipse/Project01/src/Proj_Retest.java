import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Proj_Retest {
	public static void main(String[] Args){
		GenericLinkedList<Integer> GLL = new GenericLinkedList<Integer>();
		
		File scores = new File("scores.txt");
		Integer[] scoresData = StartRead(scores);
		
		
		for(int i = 0; i<scoresData.length;i++){
			GLL.add(scoresData[i]);	
		}
		System.out.println(GLL);
		System.out.println(GLL.contains(30));
		System.out.println(GLL.get(3));
		System.out.println(GLL.indexOf(20));
		System.out.println(GLL.lastIndexOf(20));
		System.out.println(GLL.set(GLL.indexOf(20), -1));
		System.out.println(GLL);
		
		
	}
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
