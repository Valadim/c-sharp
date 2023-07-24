// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[8];

PrintEvenCount(array);

void FillArray(int[] arr)
{
  Random rnd = new Random();

  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(100, 1000);
  }
}

void PrintEvenCount(int[] arr)
{
  FillArray(arr);

  int evenCount = 0;
  var arrValue = string.Join(" ", arr);

  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0) evenCount++;
  }

  Console.WriteLine($"Элементы массива: {arrValue}");
  Console.WriteLine($"Количество четных чисел в массиве = {evenCount}");
}
