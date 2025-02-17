using System;

namespace lista09
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] matInteiros = new int[4,2];
			
			int tamanho = 10;
			int[] matriz = new int[tamanho];
			Random random = new Random();
        
        for (int i = 0; i < tamanho; i++)
        {
            matriz[i] = random.Next(1, 11); 
        }
        
        int soma = 0;
        foreach (int numero in matriz)
        {
            soma += numero;
        }
        
        Console.WriteLine("Valores gerados na matriz:");
        foreach (int numero in matriz)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine("\nSoma dos valores: " + soma);
    

				
				Console.WriteLine();
				 Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			}
			
	}

		}
