// Задача 23

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125


Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

GetCube(num);

void GetCube (int n)
{

  for (int i = 1; i <= n; i++)
  {
    Console.WriteLine($"Куб числа {i} = {i * i * i}");
  }

}