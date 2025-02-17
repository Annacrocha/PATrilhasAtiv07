public class Program
{
    static void Main(string[] args)
    {
        int tamanho = 10;
        int[,] matriz = new int[tamanho, tamanho];

        Console.WriteLine("Insira os elementos da matriz 10x10");

        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                Console.WriteLine($"Elemento [{i + 1},{j + 1}] :");
                matriz[i, j] = int.Parse(Console.ReadLine());

            }
        }

        Console.WriteLine("\nElementos da Diagonal Principal:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write(matriz[i, i] + " ");
        }

        Console.WriteLine();
        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
    }
}
