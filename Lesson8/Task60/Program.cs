// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)



int[,,] threeDimArray = GenerateThreeDimArray(2, 2, 2);

Console.WriteLine("Трехмерный массив:");

PrintThreeDimArrayWithIndexes(threeDimArray);


static int[,,] GenerateThreeDimArray(int xSize, int ySize, int zSize)
{
  int[,,] array = new int[xSize, ySize, zSize];
  Random random = new Random();

  int maxValue = xSize * ySize * zSize;

  for (int x = 0; x < xSize; x++)
  {
    for (int y = 0; y < ySize; y++)
    {
      for (int z = 0; z < zSize; z++)
      {
        int value;
        do
        {
          value = random.Next(10, 100);
        } while (IsValueAlreadyUsed(array, value, x, y, z));

        array[x, y, z] = value;
      }
    }
  }

  return array;
}

static bool IsValueAlreadyUsed(int[,,] array, int value, int currentX, int currentY, int currentZ)
{
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        if (array[x, y, z] == value && (x != currentX || y != currentY || z != currentZ))
        {
          return true;
        }
      }
    }
  }

  return false;
}

static void PrintThreeDimArrayWithIndexes(int[,,] array)
{
  int xSize = array.GetLength(0);
  int ySize = array.GetLength(1);
  int zSize = array.GetLength(2);

  for (int x = 0; x < xSize; x++)
  {
    for (int y = 0; y < ySize; y++)
    {
      for (int z = 0; z < zSize; z++)
      {
        Console.Write($"{array[x, y, z]}({x},{y},{z}) ");
      }
    }
    Console.WriteLine();
  }
}

