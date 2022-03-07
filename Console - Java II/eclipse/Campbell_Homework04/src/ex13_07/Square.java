package ex13_07;
/* Assignment: Homework 4
 * Name: Devin Campbell
 * Class: CS-216-02
 * Semester Fall 2016
 * Student ID: Dscampbe | 604149
 */
public class Square extends GeometricObject implements Colorable
{
	double side;
	
	Square(String color,boolean filled,double side){
		super(color , filled);
		this.side = side;
	}

	@Override
	public double getArea()
	{
		return side*side;
	}

	@Override
	public double getPerimeter()
	{
		return side*4;
	}

	@Override
	public void howToColor()
	{
		System.out.print("Color all four sides");
		
	}
	
	public String toString(){
		String out;
		out = "Color: "+this.getColor()+" Filled: "+this.isFilled()+" sides: "+this.side+"\n Area: "+this.getArea()+" Perimeter: "+this.getPerimeter()+"\n";
		return out;
	}
	

}
