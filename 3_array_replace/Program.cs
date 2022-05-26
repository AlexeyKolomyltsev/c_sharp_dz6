// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
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

void FReplaceArr(int[,] arr)    ///метод замены элементов массива на их квадраты, если оба индекса четные
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) arr[i,j] *= arr[i,j];
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
        arrayMN[i, j] = new Random().Next(1,10);
    }
}

PrintArr(arrayMN);

FReplaceArr(arrayMN);
PrintArr(arrayMN);