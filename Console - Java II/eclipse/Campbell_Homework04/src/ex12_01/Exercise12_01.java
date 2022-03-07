package ex12_01;


import java.util.Scanner;

public class Exercise12_01 
{
	public static void main(String[] Args)
	{
		Scanner in = new Scanner(System.in);
		
		Calculator calc = new Calculator();
		
		String var1,operand,var2,Result;
		Result="";
		var1 = in.next();
		operand = in.next();
		var2 = in.next();
		in.close();
		
		switch(operand){
			case "+":
				Result = calc.Add(var1, var2);
				break;
			case "-":
				Result = calc.Reduce(var1, var2);
				break;
			case "*":
				Result = calc.Multiply(var1, var2);
				break;
			case "/":
				Result = calc.Divide(var1, var2);
				break;
		}
		
		System.out.println(Result);
	}
	

}
