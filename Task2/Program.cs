void Programm(int m, int n, int a, int b)
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
    if (a <= m && b <= n)
    {
        Console.WriteLine($"Элемент найден: {array[a - 1, b - 1]}");
    }
    else
    {
        Console.WriteLine("Элемент с таким номером не существует(");
    }
}

Console.WriteLine("Введите размер двумерного массива m*n:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер элемента двумерного массива:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Programm(m, n, a, b);