// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digitSum = DigitSum(number);
Console.WriteLine($"Сумма цифр числа {number} равна {digitSum}");


int DigitSum(int number)
{
    int sum = 0;

    while (number != 0)
    {
        int remainder = number % 10;
        sum = sum + remainder;
        
        number /= 10;
    }

    return sum;
}


