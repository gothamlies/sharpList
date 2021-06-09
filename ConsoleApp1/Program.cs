using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<int> queue = new Stack<int>();

			for (int i = 0; i < 9; i++)
			{
				queue.Push(i + 1);
			}

			Console.WriteLine(queue.Peek());
			Console.WriteLine(queue.Pop());
			Console.WriteLine(queue.Pop());
			Console.WriteLine(queue.Pop());
		}
	}
}
