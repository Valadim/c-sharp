// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

int max = 0;
int min = 0;

if (a > b)
{
  max = a;
  min = b;
}
else
{
  max = b;
  min = a;
}

Console.WriteLine($"Большее число: {max}");
Console.WriteLine($"Меньшее число: {min}");


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

int max = 0;

if (b > c) {
  max = b;
}
else {
  max = c;
}

if (a > max) max = a;

Console.WriteLine($"Максимальное число: {max}");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
  Console.WriteLine("Число является четным.");
}
else
{
  Console.WriteLine("Число не является четным.");
}