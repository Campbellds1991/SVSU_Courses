public class GenericLinkedList<E>{
	Node<E> first;
	Node<E> current;
	Node<E> last;
	int length;
	// generic constructor
	GenericLinkedList()
	{
		first = null;
		
		last = null;
		length = 0;
	}
	// adds element to end of List
	public void add(E e){
		if(first==null){
			first = last = new Node<E>(e);
			length++;
		}else{
			current = last;
			current.next = new Node<E>(e);
			last = current.next;
			length++;
		}
		current=first;
	}
	// adds element to specific index
	public void add(int index, E e)
	{
		boolean broken = false;
		Node<E> current = first;
		if(first == null)
		{
			first = new Node<E>(e);
		}
		else if(index == 0)
		{
			Node<E> temp = first.next;
			first = new Node<E>(e,temp);
		}
		else
		{
			for(int i = 0; i<index-1;i++)
			{
				if(current != null)
				{
					current = current.next;
				}else{
					last=new Node<E>(e);
					broken = true;
					break;
				}
			}
			Node<E> temp = current.next;
			if(!broken)
			{
				current.next = new Node<E>(e,temp);	
			}
			
		}
		length++;
		current = first;
	}
	// removes element at specific index
	public void remove(int index)
	{
		Node<E> current = first;
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
		Node<E> current = first;
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
	public java.util.Iterator<E> iterator(){
		return new GenericLinkedListIterator();
	}
	private class GenericLinkedListIterator implements java.util.Iterator<E>
	{
		Node<E> current = first;
		@Override
		public boolean hasNext() 
		{
			return current.next != null;
		}

		@Override
		public E next()
		{
			current = current.next;
			return current.element;
			
		}
		
	}
}
// Node class for list elements
class Node<E>{
	protected E element;
	protected Node<E> next;
	Node(E element){
		this.element = element;
		next = null;
	}
	Node(E element, Node<E> next){
		this.element = element;
		this.next = next;
	}
}