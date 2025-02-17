public class Program
{
    static void Main()
    {
        int[,] valores = new int[4, 4];
        valores[0, 0] = 1;
        valores[0, 1] = 2;
        valores[0, 2] = 3; 
        valores[0, 3] = 4;
        valores[1, 0] = 5;
        valores[1, 1] = 6;
        valores[1, 2] = 7;
        valores[1, 3] = 8;
        valores[2, 0] = 9;
        valores[2, 1] = 10;
        valores[2, 2] = 11;
        valores[2, 3] = 12;
        valores[3, 0] = 13;
        valores[3, 1] = 14;
        valores[3, 2] = 15;
        valores[3, 3] = 16;
        
        Console.WriteLine("Valores pares: ");

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (valores[i, j] % 2 == 0)
                {
                    Console.Write(valores[i, j] + " ");
                }
            }
            
        }
        
        Console.WriteLine();
        Console.Write("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
