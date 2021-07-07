using System;

class First
{
	public static void Main(String[] args)
	{
		Console.Write("Hello ");

		foreach(String s in args)
		{
			Console.Write(s+" ");
		}
	}
}