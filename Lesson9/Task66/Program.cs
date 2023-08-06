// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int m = 1;
int n = 15;
int sum = CalculateSumOfNumbers(m, n);

if (sum == 0)
{
  Console.WriteLine("Программа завершена с ошибкой");
}
else
{
  Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n}: {sum}");
}

int CalculateSumOfNumbers(int m, int n)
{
  if (n < m)
  {
    Console.WriteLine("Неверный диапазон: n должно быть больше или равно m.");
    return 0;
  }

  if (m <= 0 || n <= 0)
  {
    Console.WriteLine("Значения m и n должны быть натуральными числами.");
    return 0;
  }

  if (m == n)
  {
    return m;
  }
  else
  {
    return m + CalculateSumOfNumbers(m + 1, n);
  }
}
