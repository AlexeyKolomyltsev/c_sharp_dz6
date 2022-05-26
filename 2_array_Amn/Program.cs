// Задать двумерный массив следующим правилом: Aₘₙ = m+n
void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк m = ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов n = ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] arrayMN = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arrayMN[i, j] = i + j;
    }
}

PrintArr(arrayMN);