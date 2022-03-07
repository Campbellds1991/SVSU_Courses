public class IntegerLinkedList{
	Node first;	
	Node last;
	int length;
	// generic constructor
	IntegerLinkedList()
	{
		first = null;
		
		last = null;
		length = 0;
	}
	// adds element to end of List
	public void add(Integer e){
		Node current = first;
		if(first==null){
			first = last = new Node(e);
			length++;
		}else{
			current = last;
			current.next = new Node(e);
			last = current.next;
			length++;
		}
		current=first;
	}
	// adds element to specific index
	public void add(int index, Integer e)
	{
		boolean broken = false;
		Node current = first;
		if(first == null)
		{
			first = new Node(e);
		}
		else if(index == 0)
		{
			Node temp = first.next;
			first = new Node(e,temp);
		}
		else
		{
			for(int i = 0; i<index-1;i++)
			{
				if(current != null)
				{
					current = current.next;
				}else{
					last=new Node(e);
					broken = true;
					break;
				}
			}
			Node temp = current.next;
			if(!broken)
			{
				current.next = new Node(e,temp);	
			}
			
		}
		length++;
		current = first;
	}
	// removes element at specific index
	public void remove(int index)
	{
		Node current = first;
		for(int i = 0; i<index-1;i++){
			current = current.next;
		}
		current.next = current.next.next;
		length--;
		current = first;
	}
	public Integer get(int index){
		Integer out;
		Node current = first;
		for(int i = 0; i<index;i++){
			current = current.next;
		}
		out = current.element;
		return out;
	}
	// converts elements to string
	public String toString()
	{
		Node current = first;
		String out = "[";
		while(current.next != null){
			out += current.element+",";
			current = current.next;
		}
		out+= current.element+"]";
		current = first;
		return out;
	}
	// can call to generate iterator
	public java.util.Iterator<Integer> iterator(){
		return new GenericLinkedListIterator();
	}
	private class GenericLinkedListIterator implements java.util.Iterator<Integer>
	{
		Node current = first;
		@Override
		public boolean hasNext() 
		{
			return current.next != null;
		}

		@Override
		public Integer next()
		{
			Integer temp = current.element;
			current = current.next;
			return temp;
			
		}
		
	}
	// Node class for list elements
	class Node{
		protected Integer element;
		protected Node next;
		Node(Integer element){
			this.element = element;
			next = null;
		}
		Node(Integer element, Node next){
			this.element = element;
			this.next = next;
		}
	}
}


