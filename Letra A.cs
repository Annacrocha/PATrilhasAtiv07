using System;

namespace lista09
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] valInteiros = new int[3,3];
			valInteiros[0,0] = 5;
			valInteiros[1,1] = 9;
			valInteiros[2,2] = 26;
			
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				     {
					Console.WriteLine(valInteiros[i, j] + " ");
				     }
				Console.WriteLine();
			}
			
			
            Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
	}

		}
            
}
