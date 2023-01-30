// Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая 
// будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

int[,,] array = GetArray(2, 2, 2, 10, 100);
GetLineByLine(array);
PrintArray(array);


int[,,] GetArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void GetLineByLine(int[,,] array)
{
    int[] newArray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number;
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        newArray[i] = new Random().Next(10, 100);
        number = newArray[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (newArray[i] == newArray[j])
                {
                    newArray[i] = new Random().Next(10, 100);
                    j = 0;
                    number = newArray[i];
                }
                number = newArray[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[z, y, z] = newArray[count];
                count++;
            }
        }
    }
}