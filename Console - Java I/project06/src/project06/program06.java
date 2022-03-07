package project06;




import java.util.*;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.text.DecimalFormat;

/* 	Filename: Program06
 * 
 * 	Author:	Devin Campbell
 * 
 *	Program Description: Patient Exam Report
 */
 
 
public class program06 {
	public static void main(String[] args) throws IOException{
		long LineCount = Files.lines(Paths.get("Results.data")).count();
		String[][] Arr = new String [(int) LineCount][6];
		
		Scanner input = new Scanner(System.in);
		for(int i = 0; i < LineCount ;i++){
			for(int j = 0; j < Arr[i].length; j++){
				if(input.hasNext()){
					Arr[i][j] = input.next();
				}
			}
		}
		
		// Show system is ready to input
		System.out.println("	Please enter data file:");
		
		// Initialize variables and counters used
		int CountError = 0, MinAt = 0, MaxAt = 0;
		double  Min = 100, Max = 0, Male = 0, Female = 0;
		String CountRed = "", CountOrange = "", CountYellow = "", CountBlue = "", CountGreen = "";
		
		// Numerical Formatting layout
		DecimalFormat Decimal = new DecimalFormat("#,##0.00"); 
		DecimalFormat Percent = new DecimalFormat("#0.00%");	
		
		// Display Heading 
		System.out.println("");
		System.out.println("*~~~< Patient Exam Report >~~~*");
		System.out.println("");
		System.out.println("Name                Patient Id Gender Exam 1  Exam 2  Exam 3   AVG   Pos/Neg");
		System.out.println("----                ---------- ------ ------  ------  ------  -----  -------");
		
		
		
		// In For loop: run each patient separately against conditions to validate then check for summary conditions
		for (int i = 0 ; i<10 ; i++){
			String PatientName = (String) input.next();
			int PatientID = input.nextInt();
			String PatientGender = input.next();
			
			float Exam1 = input.nextFloat();
			float Exam2 = input.nextFloat();
			float Exam3 = input.nextFloat();
			float ExamAvg = (Exam1+Exam2+Exam3)/3;
			String Result = null;
			boolean error = false;
			
			
			

			// validate Data from patient records
			if(Exam1>100 || Exam1<0 || Exam2>100|| Exam2<0 || Exam3>100 || Exam3<0 || PatientID < 1111 || PatientID > 9999){
				Result = "~~ Invalid Data ~~";
				error = true;
				CountError ++;
			}else{ 
				if(PatientGender.equalsIgnoreCase("M")) Male += 1;
				else if(PatientGender.equalsIgnoreCase("F")) Female += 1;
				
				// Find the Minimum and Maximum exam score
				if(ExamAvg > Max){
					Max = ExamAvg;
					MaxAt = PatientID;
				}
				if(ExamAvg < Min){
					Min = ExamAvg;
					MinAt = PatientID;
				}
				// Find Exam color Coding based on exam average
				if(ExamAvg >= 97) {
					Result = "Red"; 
					CountRed += "*";
				}
				else if(ExamAvg >= 88){
					Result = "Orange"; 
					CountOrange += "*";
				}
				else if(ExamAvg >= 78) {
					Result = "Yellow";
					CountYellow += "*";
				}
				else if(ExamAvg >= 70) {
					Result = "Blue";
					CountBlue += "*";				
				}
				else if(ExamAvg >= 0) {
					Result = "Green";
					CountGreen += "*";
				}
			}
			// Display current Patients test Record
			if(error == true){
				System.out.format("%-20s%-12d%-7s%-8s%-8s%-8s%-18s%n", PatientName, PatientID, PatientGender,  Decimal.format(Exam1),
						Decimal.format(Exam2), Decimal.format(Exam3), Result);
			}else if(error == false){
				System.out.format("%-20s%-12d%-7s%-8s%-8s%-8s%-7s%-18s%n", PatientName, PatientID, PatientGender,  Decimal.format(Exam1),
						Decimal.format(Exam2), Decimal.format(Exam3), Decimal.format(ExamAvg), Result);
			}
		}
		
		// Display Patient Summary 
		
		System.out.println("Exam Summary (If record invalid, all exam scores counted invalid)");
		System.out.println("------------");
		
		
		
		System.out.println("Patient Summary");
		System.out.println("---------------");
		System.out.println("Red     : "+CountRed);
		System.out.println("Orange  : "+CountOrange);
		System.out.println("Yellow  : "+CountYellow);
		System.out.println("Blue    : "+CountBlue);
		System.out.println("Green   : "+CountGreen);
		System.out.println("");
		System.out.println("Female  : "+Percent.format((Female / (Female+Male)))+" ("+(int)Female+" valid records)");
		System.out.println("Male    : "+Percent.format((Male / (Female+Male)))+" ("+(int)Male+" valid records)");
		System.out.println("");
		System.out.println("Valid   : "+Percent.format(((double)10.0-CountError)/10.0)+" ("+(10-CountError)+" valid records)");
		System.out.println("Invalid : "+Percent.format(((double)CountError/10.0))+" ("+(CountError)+" valid records)");
		System.out.println("");
		System.out.println("Max     : "+Decimal.format(Max)+" (Patient ID: "+MaxAt+")");
		System.out.println("Min     : "+Decimal.format(Min)+" (Patient ID: "+MinAt+")");
	

		System.out.println("");
		System.out.println("*< End of report >*");
		//Close Scanner
		input.close();
	}
}
