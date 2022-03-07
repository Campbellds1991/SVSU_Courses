

/**
 * @author Campbell, Devin
 *
 * @param <E> Generic datatype declaration
 * @param d1
 */
public class Calculator<E extends Number> {
	//standard addition of 2 numbers
	public double add(E num1, E num2){	
		double d1,d2;
		d1=Convert(num1);
		d2=Convert(num2);
		return d1+d2;
	}
	//standard subtraction of 2 numbers
	public double subtract(E num1, E num2){
		double d1,d2;
		d1=Convert(num1);
		d2=Convert(num2);
		return d1-d2;
	}
	//standard multiplication of 2 numbers
	public double multiply(E num1, E num2){	
		double d1,d2;
		d1=Convert(num1);
		d2=Convert(num2);
		return d1*d2;
	}
	//standard division of 2 numbers
	public double divide(E num1, E num2){	
		double d1,d2;
		d1=Convert(num1);
		d2=Convert(num2);
		if(d2 == 0)throw new IllegalArgumentException("Cannot Divide by 0");
		return d1/d2;
	}
	//standard average of 2 numbers
	public double average(E num1, E num2){
		double d1,d2;
		d1=Convert(num1);
		d2=Convert(num2);
		return (d1+d2)/2;		
	}
	//converts number values to doubles
	private double Convert(E e){
		return e.doubleValue();
	}
	
}
