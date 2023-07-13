Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

int thirdDigit = (number / 100) % 10;

if (thirdDigit != 0)
{
  Console.WriteLine("Третья цифра числа: " + thirdDigit);
}
else
{
  Console.WriteLine("У числа нет третьей цифры.");
}