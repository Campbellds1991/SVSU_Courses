


public class GenericLinkedList<E>{
	Node first;	
	Node last;
	int length;
	
	// generic constructor
	public GenericLinkedList()
	{
		first = null;		
		last = null;
		length = 0;
	}
	
	// adds element to end of List
	public void add(E e){
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
	public void add(int index, E e)
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
	/** Return true if this list contains the element e */
	public boolean contains(E e) {		
		Node current = first;
		for(int i = 0; current!= null ;i++){
			if(current.element == e){
				return true;
			}
			current = current.next;
		} 
		return false;
	}
	
	/** Return the element at the specified index */
	public E get(int index){
		E out;
		Node current = first;
		for(int i = 0; i<index;i++){
			if(current.next == null)return null;
			current = current.next;
		}
		out = current.element;
		return out;
	}
	
	/** Return the index of the head matching element in 
	   *  this list. Return -1 if no match. */
	public int indexOf(E e) {
		Node current = first;
		for(int i = 0; current!= null ;i++){
			if(current.element == e){
				return i;
			}
			current = current.next;
		} 
		return -1;
	}
	
	/** Return the index of the last matching element in 
	   *  this list. Return -1 if no match. */
	public int lastIndexOf(E e) {
		Node current = first;
		int indexOf = -1;
		for(int i = 0; current!= null ;i++){
			if(current.element == e){
				indexOf = i;
			}
			current = current.next;
		} 
		return indexOf;
	}
	
	 /** Replace the element at the specified position 
	   *  in this list with the specified element. */
	public E set(int index, E e) {
		Node current = first;
		for(int i = 0; i<index;i++){
			
			current = current.next;
		}
		current.element = e;
	    return current.element;
	}

	// can call to generate iterator
	public java.util.Iterator<E> iterator(){
		return new GenericLinkedListIterator();
	}
	
	private class GenericLinkedListIterator implements java.util.Iterator<E>
	{
		Node current = first;
		@Override
		public boolean hasNext() 
		{
			return current.next != null;
		}

		@Override
		public E next()
		{
			E temp = current.element;
			current = current.next;
			return temp;
			
		}
		
	}
	// Node class for list elements
	class Node{
		protected E element;
		protected Node next;
		Node(E element){
			this.element = element;
			next = null;
		}
		Node(E element, Node next){
			this.element = element;
			this.next = next;
		}
	}
}

