using System;
using System.Collections.Generic;

public class Problem20 
	{		
		// If closing appears first, return false;
		// If closing appears but does not match previous, return false;
		// If closing never appears, return false;
		
		public bool IsValid(string s) 
		{
			var mapping = GetMappings();
			
			Stack<char> opening = new Stack<char>();						
			
			for(int i = 0; i< s.Length; i++)
			{
				char letter = s[i];
				
				if(IsClosing(letter))
				{
					if(opening.Count == 0)
						return false;
					
					char pair = mapping[letter];																				
					
					if(opening.Pop() != pair)
						return false;																				
				}								
				else
					opening.Push(letter);				
			}						
			
			return opening.Count < 1;
		}
					
		Dictionary<char, char> GetMappings()
		{
			return new Dictionary<char, char>()
			{
				{'(', ')'},
				{')', '('},
				{'[', ']'},
				{']', '['},
				{'{', '}'},
				{'}', '{'},
			};
		}
		
		bool IsClosing(char letter)
		{
			return letter == ')' 
				|| letter == ']' 
				|| letter == '}';
		}
	}
