
public class SumOfN_Integers
{
	public static void main(String[] Args){
		System.out.println(SumOfN(100000));
		// test Statement
		//System.out.println(10+9+8+7+6+5+4+3+2+1);
	}
	public static long SumOfN(long n){
		if(n==0){
			return 0;
		}else{
			return n+SumOfN(n-1);
		}
	}
}
