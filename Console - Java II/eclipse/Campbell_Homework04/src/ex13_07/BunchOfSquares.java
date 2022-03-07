package ex13_07;
/* Assignment: Homework 4
 * Name: Devin Campbell
 * Class: CS-216-02
 * Semester Fall 2016
 * Student ID: Dscampbe | 604149
 */
public class BunchOfSquares
{

	public static void main(String[] args)
	{
		//Create squares
		Square[] squares = new Square[5];
		squares[0] = new Square("blue",true, 10);
		squares[1] = new Square("red",true, 20);
		squares[2] = new Square("blue",false, 40);
		squares[3] = new Square("green",true, 50);
		squares[4] = new Square("yellow",false, 2);
		
		//read squares
		for(int i = 0; i<squares.length;i++){
			System.out.print(squares[i]);
		}
		squares[0].howToColor();
	}

}
