using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class Element<T>
	{
		public Element<T> Next { get; set; }
		public Element<T> Previous { get; set; }
		public T Value { get; set; }
	}
	
}
