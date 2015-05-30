using System;



class MultiplicationSign
{
	public static void Main()
	{
		int num1 = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		int num3 = int.Parse(Console.ReadLine());
			
		if((num1 > 0) && (num2 < 0 && num3 < 0))
		{
			Console.WriteLine("+");
		}
		else if((num2 > 0) && (num1 < 0 && num3 < 0))
		{
			Console.WriteLine("+");
		}
		else if((num3 > 0) && (num2 < 0 && num1 < 0))
		{
			Console.WriteLine("+");
		}
		else if((num1 < 0) && (num2 > 0 && num3 > 0))
		{
			Console.WriteLine("-");
		}
		else if((num2 < 0) && (num1 > 0 && num3 > 0))
		{
			Console.WriteLine("-");
		}
		else if((num3 < 0) && (num2 > 0 && num1 > 0))
		{
			Console.WriteLine("-");
		}
		else if((num3 < 0) && (num2 < 0) && (num1 < 0))
		{
			Console.WriteLine("-");
		}
		else if((num3 > 0) && (num2 > 0) && (num1 > 0))
		{
			Console.WriteLine("+");
		}
		else
		{
			Console.WriteLine("0");
		}
	}
}
