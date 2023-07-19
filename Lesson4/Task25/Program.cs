// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

int GetMultiply(int x, int y)
{

  int result = 1;

  for (int i = 0; i < y; i++)
  {
    result = result * x;
  }

  return result;

}

int temp = GetMultiply(num1, num2);

Console.WriteLine($"Число {num1} в степени {num2} равно {temp}");

