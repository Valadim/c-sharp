// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = new double[5];

ShowDifference(array);

void FillArray(double[] arr)
{
  Random rnd = new Random();

  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = Math.Round(rnd.NextDouble() * 100.00, 2);
  }
}

void ShowDifference(double[] arr)
{
  FillArray(arr);

  double minElem = arr[0];
  double maxElem = arr[0];

  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] < minElem) minElem = arr[i];
    if (arr[i] > maxElem) maxElem = arr[i];
  }

  var arrValue = string.Join(" | ", arr);
  Console.WriteLine($"Элементы массива: {arrValue}");

  double result = Math.Round(maxElem - minElem, 2);

  Console.WriteLine($"Максимальный элемент: {maxElem}, минимальный элемент: {minElem}");
  Console.WriteLine($"Разница между максимальным и минимальным элементом: {result}");
}


