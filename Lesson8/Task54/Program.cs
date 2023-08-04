// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

Console.WriteLine("Исходный массив:");
PrintArray(array);

SortRowsDescending(array);

Console.WriteLine("Отсортированный массив:");
PrintArray(array);


static void SortRowsDescending(int[,] arr)
{
  int rows = arr.GetLength(0);
  for (int i = 0; i < rows; i++)
  {
    SortRowDescending(arr, i);
  }
}

static void SortRowDescending(int[,] arr, int row)
{
  int cols = arr.GetLength(1);

  for (int i = 0; i < cols - 1; i++)
  {
    for (int j = 0; j < cols - i - 1; j++)
    {
      if (arr[row, j] < arr[row, j + 1])
      {
        int temp = arr[row, j];
        arr[row, j] = arr[row, j + 1];
        arr[row, j + 1] = temp;
      }
    }
  }
}


static void PrintArray(int[,] arr)
{
  int rows = arr.GetLength(0);
  int cols = arr.GetLength(1);

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
  }
}
