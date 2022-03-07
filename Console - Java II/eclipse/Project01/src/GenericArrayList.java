import java.util.Iterator;

public class GenericArrayList<E>
{	
	private E list[];
	public static final int DEFAULT_SIZE = 20;
	private int size;
	
	//Base Constructor
	GenericArrayList(){
		this(DEFAULT_SIZE);
	}
	//Specified Constructor
	GenericArrayList(int size){
		list = (E[]) new Object[size];		
	}
	//Adds element to end (default) location
	public void add(E element){
		if(HasEmptyIndex()){
			list[size++] = element;
		}else{
			createExtendedList();
			list[size++] = element;
		}
	}
	//Adds element to specified index
	public void add(E element, int index){
		translate(1,index);
		list[index] = element;
		size++;
	}
	//Returns element in specified location	
	public E get(int index){
		return list[index];
	}
	//Returns the number of filled elements in the set
	public int getSize(){
		return  size;
	}
	//Removes single element at index from array
	public void remove(int index){
		translate(-1,index);
		size--;
	}
	//Removes elements from a starting to ending index
	public void remove(int left,int right){
		translate(right-left,left);
		size-=right-left;
	}
	//clears all values from the array.
	public void clear(){
		list = (E[]) new Object[DEFAULT_SIZE];
	}
	//Checks to see if the array has space
	public boolean HasEmptyIndex() {
		if(list.length >= size ){
			return true;
		}else{
			return false;
		}
	}
	//Primary method of adjusting array for adding or removal of elements
	private void translate(int translation, int indexLeft){
		if(translation>0){
			if(!HasEmptyIndex())createExtendedList();
			for(int i = list.length-2; i>=indexLeft; i--){
				list[i+translation] = list[i];
			}
			list[indexLeft]= null;
		}else if(translation<0){
			for(int i = indexLeft;i<list.length-1;i++ ){
				list[i+translation] = list[i];
			}for(int i = 0;i>translation;i--){
				list[list.length-1-i] = null;
			}
			
		}
	}
	//Extends the existing array by 20%
	private void createExtendedList(){
		int newSize = (int) Math.ceil(list.length*1.2);
		E[] temp = (E[]) new Object[newSize];
		for(int i = 0;i<list.length;i++){
			temp[i] = list[i];
		}
		list = temp;
	}
	//Overridden Iterator used to iterate the list
	protected class ArrayListIterator implements Iterator<E>{
		private int index;
		private GenericArrayList<E> list;
		
		ArrayListIterator(GenericArrayList<E> list){
			this.list = list;
			index=0;
		}
		public boolean hasNext(){
			return !(list.size >= index);
		}

		@Override
		public E next() {
			if(hasNext()){
				return list.get(index++);
			}else{
				throw new IndexOutOfBoundsException("End of Array: (Last Element: "+list.get(index)+")");
			}
		}
		public void remove(){
			if(index <= 0){
				throw new IllegalStateException("Cannot remove element before first next() call.");
			}
			list.remove(index);
		}
					
	}
	
}
