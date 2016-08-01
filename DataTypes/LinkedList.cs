public class LinkedList<T>
	{
		private class Node
		{
			public Node Next {get; set;}
			
			public T Value {get; private set;}
			
			public Node(T value)
			{
				Value = value;	
			}			
		}
		
		private Node _head;
		
		public void AddToFront(T data)
		{
			Node node = new Node(data);
			
			node.Next = _head;
			
			_head = node;
		}
		
		public void AddToEnd(T data)
		{
			Node node = new Node(data);
			
			if(_head == null)
			{				
				_head = node;
				
				_head.Next = null;
			}
			else
			{
				Node current = _head;								
				
				while(current.Next != null)
				{
					Console.WriteLine("current is not null, is: " + current.Value);
					
					current = current.Next;	
				}
				
				Console.WriteLine("Assigning " + data);
				
				current.Next = node;
			}
		}
		
		public void PrintAllNodes()
		{
			Node current = _head;
			
			while(current != null)
			{
				Console.WriteLine(current.Value);
				
				current = current.Next;
			}
		}
	}
