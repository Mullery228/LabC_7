void Programm(int m, int n)
{
    int[,] array = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(100);
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    for (int j = 0; j < n; j++)
    {
        float sum = 0;
        for (int i = 0; i < m; i++)
        {
            sum += array[i, j];
        }
        Console.Write(sum / n);
        Console.Write("; ");
    }
}

Console.WriteLine("Введите размер двумерного массива m*n:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Programm(m, n);