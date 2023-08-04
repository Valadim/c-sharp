// Задача 62. Напишите программу, которая заполнит 
// спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] spiralArray = FillSpiralArray(4, 4);

Console.WriteLine("Спиральный массив:");

PrintArray(spiralArray);


static int[,] FillSpiralArray(int rows, int cols)
{
  int[,] array = new int[rows, cols];
  int value = 1;
  int topRow = 0, bottomRow = rows - 1;
  int leftCol = 0, rightCol = cols - 1;

  while (value <= rows * cols)
  {
    for (int col = leftCol; col <= rightCol; col++)
    {
      array[topRow, col] = value++;
    }

    for (int row = topRow + 1; row <= bottomRow; row++)
    {
      array[row, rightCol] = value++;
    }

    if (topRow < bottomRow && leftCol < rightCol)
    {
      for (int col = rightCol - 1; col > leftCol; col--)
      {
        array[bottomRow, col] = value++;
      }

      for (int row = bottomRow; row > topRow; row--)
      {
        array[row, leftCol] = value++;
      }
    }

    topRow++;
    bottomRow--;
    leftCol++;
    rightCol--;
  }

  return array;
}

static void PrintArray(int[,] array)
{
  int rows = array.GetLength(0);
  int cols = array.GetLength(1);

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      Console.Write($"{array[i, j], 5}");
    }
    Console.WriteLine();
  }
}
