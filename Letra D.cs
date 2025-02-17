public class Program
{
    static void Main(10)
    {
        int tamanho = 10;
        int[,] matriz = new int[tamanho, tamanho];

        Console.WriteLine("Insira os elementos da matriz 10x10:");
        
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                Console.Write($"Elemento [{i+1},{j+1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nElementos fora da diagonal principal:");
        
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                if (i != j)
                {
                    Console.Write(matriz[i, j] + " ");
                }
            }
        }

        Console.WriteLine();
        Console.Write("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
