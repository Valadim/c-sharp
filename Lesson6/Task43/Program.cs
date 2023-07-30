// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

FindIntersectionPoint(2, 5, 4, 9);

void FindIntersectionPoint(double b1, double k1, double b2, double k2)
{
  if (k1 == k2)
  {
    Console.WriteLine("Прямые параллельны и не имеют точки пересечения.");
  }
  else
  {
    double xIntersection = (b2 - b1) / (k1 - k2);
    double yIntersection = k1 * xIntersection + b1;

    Console.WriteLine($"Точка пересечения прямых: ({xIntersection}, {yIntersection})");
  }
}


