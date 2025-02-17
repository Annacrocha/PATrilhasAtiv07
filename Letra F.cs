public class Program
{
    static void Main()
    {
        int[,] valores = new int[3, 3];
        Random gerador = new Random();

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                valores[i, j] = gerador.Next(1, 100);
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(valores[i, j] + "\t");
            }
        }
        
        Console.WriteLine();
        Console.Write("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
