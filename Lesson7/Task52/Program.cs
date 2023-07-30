// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = { {1, 4, 7, 2},
                 {5, 9, 2, 3},
                 {8, 4, 2, 4}
               };

FindAverageSum(array);

void FindAverageSum(int[,] arr)
{
  double sum = 0;

  for (int i = 0; i < arr.GetLength(1); i++)
  {
    for (int j = 0; j < arr.GetLength(0); j++)
    {
      sum += arr[j, i];
    }
    
    sum = Math.Floor(sum / arr.GetLength(0) * 10) / 10;

    Console.WriteLine($"Среднне арифмитическое {i + 1} столбца: {sum}");

    sum = 0;
  }
}

