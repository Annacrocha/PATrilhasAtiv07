public class Program
{
    static void Main()
    {
        float[,] valores = new float[2, 2];
        valores[0, 0] = 1.2f;
        valores[0, 1] = 3.4f;
        valores[1, 0] = 5.6f;
        valores[1,1] = 7.8f;

        float[] media = new float[2];
        for (int i = 0; i < 2; i++)
        {
            media[i] = (valores[i] + valores[i + 1]) / 2;
            Console.WriteLine("Média: " + media[i]);
        }
        Console.WriteLine();
        Console.Write("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
