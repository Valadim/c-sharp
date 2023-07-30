// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел вы хотите ввести?");
int cnt = Convert.ToInt32(Console.ReadLine());

int[] userArr = FillArray(cnt);
GetPositiveNumbersCount(userArr);

int[] FillArray(int count)
{
  int[] arrayNumber = new int[count];
  int index = 0;

  while (count > 0)
  {

    Console.WriteLine($"Введите {index + 1} число ");
    arrayNumber[index] = Convert.ToInt32(Console.ReadLine());

    index++;
    count--;
  }
  return arrayNumber;
}

void GetPositiveNumbersCount(int[] arr)
{
  int positiveNumbers = 0;

  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > 0) positiveNumbers++;
  }

  Console.WriteLine($"Количиство чисел больше 0: {positiveNumbers}");
}

