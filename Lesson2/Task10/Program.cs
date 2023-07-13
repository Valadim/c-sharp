Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine());

int secondDigit = (number / 10) % 10;

Console.WriteLine("Вторая цифра числа: " + secondDigit);