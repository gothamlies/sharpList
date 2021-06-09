using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class List<T>
	{

		private Element<T> first;
		private Element<T> last;

		public int Count { get; private set; }

		public List()
		{
			Count = 0;
		}

		private void AddFirst(T value)
		{
			Element<T> newElement = CreateElement();

			newElement.Value = value;
			last = first = newElement;
		}

		private Element<T> CreateElement()
		{
			Count++;
			return new Element<T>();
		}

		public void PushBack(T value)
		{
			if (last == null)
			{
				AddFirst(value);
				return;
			}

			Element<T> newElement = CreateElement();

			newElement.Value = value;
			newElement.Previous = last;

			last.Next = newElement;
			last = newElement;
		}

		public void PushFront(T value)
		{
			if (last == null)
			{
				AddFirst(value);
				return;
			}

			Element<T> newElement = CreateElement();

			newElement.Value = value;
			newElement.Next = first;

			first.Previous = newElement;
			first = newElement;
		}

		public void Insert(int index, T value)
		{
			if (first == null)
			{
				AddFirst(value);
				return;
			}

			var element = GetElement(index);

			Element<T> newElement = CreateElement();
			newElement.Value = value;

			newElement.Next = element.Next;
			element.Next = newElement;
			newElement.Previous = element;
		}

		public Element<T> Remove(int index)
		{
			var element = GetElement(index);
			if (element == null) throw new IndexOutOfRangeException();

			if (element.Previous != null)
			{
				element.Previous.Next = element.Next;
			}
			else
			{
				first = element.Next;
			}

			if (element.Next != null)
			{
				element.Next.Previous = element.Previous;
			}
			else
			{
				last = element.Previous;
			}

			element.Next = null;
			element.Previous = null;

			Count--;

			return element;
		}

		public T Get(int index)
		{
			return GetElement(index).Value;
		}

		public Element<T> GetElement(int index)
		{
			if (index > Count)
			{
				throw new IndexOutOfRangeException();
			}

			var current = first;
			int i = 0;
			while (current != null)
			{
				if (i == index) return current;

				i++;

				current = current.Next;
			}

			return null;
		}

		public override string ToString()
		{
			string str = "[";
			var current = first;
			while (current != null)
			{
				str += $"{current.Value},";
				current = current.Next;
			}
			str = str.Substring(0, str.Length - 1) + "]";

			return str;
		}
	}
}
