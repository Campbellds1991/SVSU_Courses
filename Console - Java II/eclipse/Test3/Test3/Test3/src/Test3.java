import java.util.Iterator;

public class Test3 {
	public static void main(String[] Args){
		GenericLinkedList<Integer> Llist = new GenericLinkedList<Integer>();
		
		Llist.add(10);
		Llist.add(20);
		Llist.add(30);
		Llist.add(40);
		Llist.add(50);
		Llist.remove(1);
		System.out.println(Llist);
		Iterator<Integer> iterator = Llist.iterator();
		
		while(iterator.hasNext()){
			System.out.print(iterator.next()+" ");
		}
		
	}

}
