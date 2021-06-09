using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class Queue<T>
	{
		private List<T> list;

		public Queue()
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

		public void Enqueue(T value)
		{
			list.PushBack(value);
		}

		public T Dequeue()
		{
			return list.Remove(0).Value;
		}

		public T Peek()
		{
			return list.GetElement(0).Value;
		}
	}
}
