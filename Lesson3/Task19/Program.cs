﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(IsPalindrome(number) ? "Данное число является палиндромом." : "Данное число не является палиндромом.");


bool IsPalindrome(int number)
{
    int originalNumber = number;
    int reversedNumber = 0;

    while (number != 0)
    {
        int remainder = number % 10;
        reversedNumber = reversedNumber * 10 + remainder;
        number /= 10;
    }

    return originalNumber == reversedNumber;
}