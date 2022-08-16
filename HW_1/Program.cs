// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = 0;
if (n >= 100 && n <= 999)
{
    res = n % 100;
    res = res / 10;
    Console.WriteLine("Вторая цифра числа: " + res);
}
else
{
    Console.WriteLine("Нужно ввести трёхзначное число");
}
