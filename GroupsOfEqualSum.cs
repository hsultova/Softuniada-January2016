using System;

namespace Softuniada
{
	class GroupsOfEqualSum
	{
		static void Main(string[] args)
		{
			var a = int.Parse(Console.ReadLine());
			var b = int.Parse(Console.ReadLine());
			var c = int.Parse(Console.ReadLine());
			var d = int.Parse(Console.ReadLine());

			string result = "";
			int sum = 0;

			if (a + c == b + d)
			{
				result = "Yes";
				sum = a + c;
			}
			else if (a + b == c + d)
			{
				result = "Yes";
				sum = a + b;
			}
			else if (a == b + c + d)
			{
				result = "Yes";
				sum = a;
			}
			else if (b == a + c + d)
			{
				result = "Yes";
				sum = b;
			}
			else if (c == a + b + d)
			{
				result = "Yes";
				sum = c;
			}
			else if (d == a + b + c)
			{
				result = "Yes";
				sum = d;
			}
			else
			{
				result = "No";
			}

			Console.WriteLine(result);
			if (sum != 0)
				Console.WriteLine(sum);
		}
	}
}