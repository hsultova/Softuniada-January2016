using System;

namespace Softuniada
{
	class House
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			int leftRight = n - 1;
			int mid = 1;

			//roof
			Console.WriteLine("{0}*{0}", new string('.', leftRight));
			for (int i = 0; i < n - 2; i++)
			{
				leftRight--;
				Console.WriteLine("{0}*{1}*{0}", new string('.', leftRight), new string(' ', mid));
				mid += 2;
			}
			//Console.WriteLine(new string('*', 2 * n - 1));
			int count = 0;
			while (count < n - 1 / 2)
			{
				Console.Write("*");
				Console.Write(" ");
				count++;
			}
			Console.WriteLine();

			//house
			Console.WriteLine("+{0}+", new string('-', 2 * n - 3));
			for (int i = 0; i < n - 2; i++)
			{
				Console.WriteLine("|{0}|", new string(' ', 2 * n - 3));
			}
			Console.WriteLine("+{0}+", new string('-', 2 * n - 3));
		}
	}
}
