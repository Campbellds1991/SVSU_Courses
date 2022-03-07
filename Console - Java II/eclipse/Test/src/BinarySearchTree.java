class BinarySearchTree<E extends Comparable<E>> {
	Node Root;
	int Count;
	
	public BinarySearchTree(){
		Root = null;
	}
	public BinarySearchTree(E[] arr){
		for(int i = 0;i<arr.length;i++){
			insert(arr[i]);
		}
	}
	
	public boolean insert(E e) {
		Node newNode = new Node(e);		
		if(Root == null){
			Root = newNode;
			return true;
		}
		Node parent = Root;
		Node current = Root;
		while(true){
			parent = current;
			int i = (current.element).compareTo(e);
			if(i == 0){
				return false;
			}else if(i<0){
				current = current.left;
				if(current == null){
					parent.left = newNode;
					return true;
				}
			}else{
				current = current.right;
				if(current == null){
					parent.right = newNode;
					return true;
				}
			}
		}
	}
	
	public boolean Find(E e){
		Node current = Root;
		while(current != null){
			int i = (current.element).compareTo(e);
			
			if(i==0)return true;
			else if(i<0)current = current.right;
			else current = current.left;		
		}
		return false;
	}
	
	public void inorder(Node root){
		if(Root == null)return;
		inorder(root.left);
		System.out.print(root.element+" ");
		inorder(root.right);
	}
	
	public void preorder(Node root){
		if(Root == null)return;
		System.out.print(root.element+" ");
		preorder(root.left);		
		preorder(root.right);
	}
	
	public void postorder(Node root){
		if(Root == null)return;		
		postorder(root.left);		
		postorder(root.right);
		System.out.print(root.element+" ");
	}
	
	public void breadthFirst(){
		if(Root == null)return;
		Node[] roots = (BinarySearchTree<E>.Node[]) new Object[1];
		roots[0] = Root;
		Node[] branches = (BinarySearchTree<E>.Node[]) new Object[2];
		branches[0] = Root.left;
		branches[1] = Root.right;
		boolean clearFlag = true;
		while(clearFlag){
			clearFlag=false;
			for(int i = 0; i<roots.length; i++){
				if(roots[i] != null){
					System.out.print(((Node)roots[i]).element+" ");
					clearFlag = true;
				}
				int newBranchLength = branches.length * 2;
				roots = branches;
				branches = (BinarySearchTree<E>.Node[]) new Object[newBranchLength];
			}
		}		
	}
	
	private class Node{
		E element;
		Node left;
		Node right;
		public Node(E element){
			this.element = element;
			left = null;
			right = null;
		}
	}
	
}