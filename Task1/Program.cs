void Programm(int m, int n)
{
    double[,] array = new double[m, n];
    Random r = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double dr = r.NextDouble();
            double a = (dr * 99) + 1;
            array[i, j] = a;
            Console.Write("{0:0.##}   ", array[i, j]);
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер двумерного массива m*n:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Programm(m, n);