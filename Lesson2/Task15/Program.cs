Console.WriteLine("Введите цифру дня недели (1-7):");
int dayOfWeek = int.Parse(Console.ReadLine());

if (dayOfWeek >= 1 && dayOfWeek <= 7)
{
  bool isWeekend = (dayOfWeek == 6 || dayOfWeek == 7);

  if (isWeekend)
  {
    Console.WriteLine("День является выходным.");
  }
  else
  {
    Console.WriteLine("День не является выходным.");
  }
}
else
{
  Console.WriteLine("Некорректный номер дня недели. Введите число от 1 до 7.");
}