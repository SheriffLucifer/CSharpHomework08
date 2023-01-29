// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

int[,] array = GetArray(5, 10, 0, 10);
PrintArray(array);

int sum = SumLineElements(array, 0);
int minSum = MinSum(sum);

Console.WriteLine($"\n Наименьшая сумма элементов ({sum}) в строке {minSum + 1}");

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

int SumLineElements(int[,] array, int k)
{
    int sum = array[k, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[k, j];
    }
    return sum;
}

int MinSum(int sum)
{
    int minSum = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSum = SumLineElements(array, i);
        if (sum > tempSum)
        {
            sum = tempSum;
            minSum = i;
        }
    }
    return minSum;
}