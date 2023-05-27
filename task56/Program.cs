//Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray(int[,] arr)
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

int SumLine(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

void FindingMinimumAmount(int[,] array)
{
    int rowMinSum = 0;
    int minSum = SumLine(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = SumLine(array, i);
        if (minSum > tempSumLine)
        {
            minSum = tempSumLine;
            rowMinSum = i;
        }
    }

    Console.WriteLine($"\nНаименьшая сумма элементов {minSum}, в строке {rowMinSum + 1}");
}

const int rows = 4;
const int cols = 5;
int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
FindingMinimumAmount(array);