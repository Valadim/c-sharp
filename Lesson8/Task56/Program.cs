﻿// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей 
// суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка



int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

int minRow = FindRowWithMinSum(array);

Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow + 1} строка");


static int FindRowWithMinSum(int[,] arr)
{
  int rows = arr.GetLength(0);
  int cols = arr.GetLength(1);
  int minSum = int.MaxValue;
  int minRow = -1;

  for (int i = 0; i < rows; i++)
  {
    int sum = 0;
    for (int j = 0; j < cols; j++)
    {
      sum += arr[i, j];
    }

    if (sum < minSum)
    {
      minSum = sum;
      minRow = i;
    }
  }

  return minRow;
}
