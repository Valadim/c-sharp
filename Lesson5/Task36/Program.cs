// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];

SumEvenElement(array);

void FillArray(int[] arr)
{
  Random rnd = new Random();

  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(-100, 100);
  }
}

void SumEvenElement(int[] arr)
{
  FillArray(arr);

  int evenSum = 0;
  var arrValue = string.Join(" ", arr);

  for (int i = 1; i < arr.Length; i += 2)
  {
    evenSum = evenSum + arr[i];
  }

  Console.WriteLine($"Элементы массива: {arrValue}");
  Console.WriteLine($"Сумма четных элементов = {evenSum}");
}
