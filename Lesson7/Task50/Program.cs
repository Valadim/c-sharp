// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

int[,] array = { { 1, 4, 7, 2 },
                 { 5, 9, 2, 3 },
                 { 8, 4, 2, 4 }
               };


GetElementFromMultipleArray(array);

void GetElementFromMultipleArray(int[,] arr)
{

  Console.Write("Введите координат X:");
  int xCoord = Convert.ToInt32(Console.ReadLine());

  Console.Write("Введите координат Y:");
  int yCoord = Convert.ToInt32(Console.ReadLine());

  if (xCoord > arr.GetLength(0) || yCoord > arr.GetLength(1))
  {
    Console.WriteLine("Такого элемента в массиве нет");
  }
  else
  {
    Console.WriteLine($"Значение элемента: {arr[xCoord, yCoord]}");
  }
}

