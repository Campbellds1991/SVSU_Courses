package ex12_01;


import java.text.DecimalFormat;

public class Calculator
{
	String userInput1, userInput2;
	double a,b;
	DecimalFormat dfResult = new DecimalFormat("#,##0.####");
	DecimalFormat dfQuery = new DecimalFormat("#,##0.#");
	Calculator(){
		
	}
	
	String Add(String value1, String value2)
	{
		String out = null;
		a = tryParse(value1);
		b = tryParse(value2);
		out = a+" + "+b+" = "+(a+b);
		return out;
	}
	String Reduce(String value1, String value2)
	{
		String out = null;
		a = tryParse(value1);
		b = tryParse(value2);
		out = a+" - "+b+" = "+(a-b);
		return out;
	}
	String Multiply(String value1, String value2)
	{
		String out = null;
		a = tryParse(value1);
		b = tryParse(value2);
		out = dfQuery.format(a)+" * "+dfQuery.format(b)+" = "+dfResult.format(a*b);
		return out;
	}
	String Divide(String value1, String value2)
	{
		String out = null;
		
		a = tryParse(value1);
		b = tryParse(value2);
		if(b == 0){
			throw new IllegalArgumentException("Cannot Divide By Zero");
		}else{
			out = dfQuery.format(a)+" / "+dfQuery.format(b)+" = "+dfResult.format(a/b);
		}
		return out;
	}
	double tryParse(String value){
		double temp = 0;
		try{
			temp = Double.parseDouble(value);
		}
		catch(Exception e)
		{
			System.out.println(value +" is not a valid Numerical expression, try again.");
			System.exit(-1);
		}
		
		return temp;
	}
}
