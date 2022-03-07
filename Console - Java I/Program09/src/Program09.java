/* 	Filename: Program09
 * 
 * 	Author:	Devin Campbell
 *  Class: 	CS116-02-MW
 * 
 *	Program Description: Creates stopwatch, generates arrays, then calculates 
 *						and displays time to finish sorting.
 */
public class Program09 {
	public static void main(String[] Args){
		// create Stopwatch object
		StopWatch sw = new StopWatch();
		// create Quicksort Object
		MyQuickSort Sort = new MyQuickSort();
		//generate 100,000 random numbers to be sorted
		int[] test = new int[1000000];
		for(int i=0; i < test.length; i++){
			test[i] = (int) (100000 * Math.random());
		}
		// start stopwatch
		sw.Start();
		// sort array
		Sort.sort(test);
		// stop stopwatch
		sw.Stop();
		// display time elapsed
		System.out.println("Sort took " + sw.GetElapsedTime() + " Milliseconds.");
	}
}
class StopWatch{
	long StartTime;
	long StopTime;
	// construct for stopwatch object
	StopWatch(){
		StartTime = System.currentTimeMillis();		
	}
	// sets start time
	public void Start(){
		StartTime = System.currentTimeMillis();
	}
	// sets stop time
	public void Stop(){
		StopTime = System.currentTimeMillis();
	}
	// returns time between start and stop in milliseconds.
	public long GetElapsedTime(){
		return (StopTime - StartTime);
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

