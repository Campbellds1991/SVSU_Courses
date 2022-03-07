package program08;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;

import java.util.Scanner;
/* 	Filename: Program08
 * 
 * 	Author:	Devin Campbell
 *  Class: 	CS116-02-MW
 * 
 *	Program Description: reads file, generates arrays, manipulates data inside array
 *						sorts the array by columns, then displays arrays, max, min, avg, and more.
 */
public class Program08 {
	static int Arr1x[] = new int[10];
	static int Arr2x[][] = new int[10][10];
	
	public static void main(String[] Args) throws FileNotFoundException, IOException {				
		GetData();	
		PrintMaxMinAvg();
		Generate2dArray();
		Print2dArray(Arr2x);	
		FindPrintMoreThan100();
		Arr1x = QuickSort(Arr1x);
		Fliped2dArray();
		Print2dArray(Arr2x);			
	}
	// Reads the file and generates a 1d array
	static void GetData() throws FileNotFoundException, IOException{
		Scanner input = new Scanner(new File("input.data"));
		for(int i = 0; input.hasNext(); i++){
			Arr1x[i] = input.nextInt();
			Arr1x[i] = AddOne(Arr1x[i]);
			Arr1x[i] = AddOnOddIndex(i, Arr1x[i]);
		}
		input.close();
		
	}
	//turns a 1d array into a cloned 2d array, copied by row
	static void Generate2dArray(){
		for(int i = 0; i<10; i++){
			for(int j = 0; j<10; j++){
				Arr2x[i][j]= Arr1x[i];
			}
		}
	}
	// turn rows into columns and vice versa
	static void Fliped2dArray(){
		for(int i = 0; i<10; i++){
			for(int j = 0; j<10; j++){
				Arr2x[j][i]= Arr1x[i];
			}
		}
	}
	// add one to all odd values
	static int AddOne(int i){
		if(i % 2 == 0)i++;
		return i;
		}
	// add 2 if index is odd
	static int AddOnOddIndex (int i, int x){
		if(i%2 != 0)x+=2;
		return x;
	}
	// write 2d array to console
	static void Print2dArray(int arr[][]){
		for(int i = 0; i < arr.length; i++){
			for(int j =0 ; j < arr[i].length; j++){
				System.out.printf("%4d ",arr[i][j]);
			}
			System.out.println();
		}
	}
	// maximum function for a 1d array
	static int FindMax(int[] arr){
		int Max = 0 ;
		for(int i = 0; i < 10; i++){
			if(arr[i] > Max) Max = arr[i];
		}
		return Max;
	}
	// Minimum function for a 1d array
	static int FindMin(int[] arr){
		int Min = Integer.MAX_VALUE;
		for(int i = 0; i < 10; i++){
			if(arr[i] < Min) Min = arr[i];
		}
		return Min;
	}
	// Average function for a 1d array
	static double FindAvg(int[] arr){
		int sum = 0;
		int count = arr.length;
		for(int i = 0; i<arr.length; i++){
			sum = arr[i];
		}
		return ((double)sum/(double)count);
	}
	// Display Min, Max, and Avg
	static void PrintMaxMinAvg(){
		System.out.println("Max: " + FindMax(Arr1x));
		System.out.println("Min: " + FindMin(Arr1x));
		System.out.println("Avg: "+ FindAvg(Arr1x));
	}
	// Display Values greater then 100
	static void FindPrintMoreThan100(){
		System.out.println("*--<Values greater than 100>--*");
		for(int i = 0; i < 10; i++){
			if(Arr1x[i] >= 100) System.out.println(Arr1x[i]);
		}
	}
	// Quicksort method calling quicksort class
	static int[] QuickSort(int[] Arr){
		MyQuickSort sorter = new MyQuickSort();
		Arr = sorter.sort(Arr);
		return Arr;
	}
}

class MyQuickSort {
    
    private int array[];
    private int length;
 
    public int[] sort(int[] inputArr) {
         
        if (inputArr == null || inputArr.length == 0) {
            return null;
        }
        this.array = inputArr;
        length = inputArr.length;
        quickSort(0, length - 1);
        return array;
    }
    //Quicksort Object Class
    private void quickSort(int lowerIndex, int higherIndex) {
         
        int i = lowerIndex;
        int j = higherIndex;
        // calculate pivot number, I am taking pivot as middle index number
        int pivot = array[lowerIndex+(higherIndex-lowerIndex)/2];
        // Divide into two arrays
        while (i <= j) {
            /**
             * In each iteration, we will identify a number from left side which
             * is greater then the pivot value, and also we will identify a number
             * from right side which is less then the pivot value. Once the search
             * is done, then we exchange both numbers.
             */
            while (array[i] < pivot) {
                i++;
            }
            while (array[j] > pivot) {
                j--;
            }
            if (i <= j) {
                exchangeNumbers(i, j);
                //move index to next position on both sides
                i++;
                j--;
            }
        }
        // call quickSort() method recursively
        if (lowerIndex < j)
            quickSort(lowerIndex, j);
        if (i < higherIndex)
            quickSort(i, higherIndex);
    }
 
    private void exchangeNumbers(int i, int j) {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
