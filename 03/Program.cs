// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

Console.Clear();

Console.Write("Введите количество строк первого массива: ");
int a = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите кол-во столбцов первого массива (и кол-во строк второго массива): ");
int b = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов второго массива: ");
int c = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Первая матрица");
int[,] array1 = GetArray(a, b, 0, 10);
PrintArray(array1);

Console.WriteLine("Вторая матрица");
int[,] array2 = GetArray(b, c, 0, 10);
PrintArray(array2);

int[,] productArrays = new int[a, c];
MultiplyArrays(array1, array2, productArrays);
Console.WriteLine($"Произведение двух матриц:");
PrintArray(productArrays);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MultiplyArrays(int[,] firstArray, int[,] secondArray, int[,] productArrays)
{
    for (int i = 0; i < productArrays.GetLength(0); i++)
    {
        for (int j = 0; j < productArrays.GetLength(1); j++)
        {
            int product = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                product += firstArray[i, k] * secondArray[k, j];
            }
            productArrays[i, j] = product;
        }
    }
}
