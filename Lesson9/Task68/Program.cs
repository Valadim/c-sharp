﻿// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = 2;
int n = 3;

int result = AckermannFunction(m, n);

if (result == 0)
{
  Console.WriteLine("Программа завершена с ошибкой");
}
else
{
  Console.WriteLine($"A({m}, {n}) = {result}");
}

int AckermannFunction(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if (m > 0 && n == 0)
  {
    return AckermannFunction(m - 1, 1);
  }
  else if (m > 0 && n > 0)
  {
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
  }
  else
  {
    Console.WriteLine("Значения m и n должны быть неотрицательными целыми числами.");
    return 0;
  }
}

