using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class Stack<T>
	{
		private List<T> list;

		public Stack()
		{
			list = new List<T>();
		}

		public int Count
		{
			private set { }
			get
			{
				return list.Count;
			}
		}

		public void Push(T value)
		{
			list.PushBack(value);
		}

		public T Pop()
		{
			return list.Remove(Count - 1).Value;
		}

		public T Peek()
		{
			return list.GetElement(Count - 1).Value;
		}
	}
}
