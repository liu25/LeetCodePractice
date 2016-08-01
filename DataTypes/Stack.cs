public class Stack<T>
	{
		T[] _array;
		
		int _currentIndex;
		
		public Stack(int size)
		{
			if(size <= 0)
				throw new ArgumentOutOfRangeException();
			
			_array = new T[size];
			
			_currentIndex = 0;
		}
		
		public void Push(T value)
		{
			if(_currentIndex > _array.Length-1)
				Resize();
			
			_array[_currentIndex] = value;
			
			_currentIndex++;
		}
		
		private void Resize()
		{
			Array.Resize(ref _array, _array.Length*2);	
		}

		public T Pop()
		{
			if(_currentIndex <=0)
				throw new InvalidOperationException("The stack is empty");
			
			return _array[--_currentIndex];						
		}
	}
