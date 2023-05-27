//Задача 54: Задайте двумерный массива.
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.




void CreateRandomArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        arr[i, j] = new Random().Next(1, 100);
      }
    }
}

void ShowArray(int[,] arr)
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

void DescendingArrayNumbers(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

const int numberOfLines = 5;
const int numberOfColumns = 4;
int[,] array = new int[numberOfLines, numberOfColumns];

CreateRandomArray(array);
ShowArray(array);

Console.WriteLine($"Отсортированный массив: ");
DescendingArrayNumbers(array);
ShowArray(array);