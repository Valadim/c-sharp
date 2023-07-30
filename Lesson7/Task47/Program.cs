// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] array = new double[5, 4];

FillDoubleArray(array, -10.0);

PrintMultiplyArray(array);

double[,] FillDoubleArray(double[,] arr, double minValue = 1.0, double maxValue = 10.0, int round = 1)
{
  Random random = new Random();
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = Math.Round(random.NextDouble() * (maxValue - minValue) + minValue, round);
    }
  }

  return arr;
}

void PrintMultiplyArray(double[,] arr) {

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
  }
}