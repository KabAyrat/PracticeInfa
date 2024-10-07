using System;

class Program
{
    static void Main()
    {
        int[][] matrica = new int[5][];
        matrica[0] = new int[5];
        matrica[1] = new int[3];
        matrica[2] = new int[8];
        matrica[3] = new int[4];
        matrica[4] = new int[6];

        Random random = new Random();

        for (int i = 0; i < matrica.Length; i++)
        {
            for (int j = 0; j < matrica[i].Length; j++)
            {
                matrica[i][j] = random.Next(-500, 501); 
            }
        }

        Console.WriteLine("Ступенчатый массив и суммы строк:");
        for (int i = 0; i < matrica.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j < matrica[i].Length; j++)
            {
                Console.Write(matrica[i][j] + "\t");
                sum += matrica[i][j];  
            }
            Console.WriteLine(" | Сумма: " + sum); 
        }
    }
}
