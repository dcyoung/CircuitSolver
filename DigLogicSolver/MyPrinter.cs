using System;

namespace DigLogicSolver
{
	public class MyPrinter
	{
		public MyPrinter()
		{

		}
		public void print(int i)
		{
			Console.WriteLine ("{0}", i);
		}

		public void print(double f)
		{
			Console.WriteLine ("{0}", f);
		}

		public void print(string s)
		{
			Console.WriteLine ("{0}", s);
		}

		public void print(string msg, int i)
		{
			Console.WriteLine (msg + " {0}", i);
		}

		public void print(string msg, double f)
		{
			Console.WriteLine (msg + " {0}", f);
		}

		public void print(string msg, bool b)
		{
			Console.WriteLine (msg + " {0}", b);
		}
	}
}

