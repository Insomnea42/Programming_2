// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");

int chislo = Convert.ToInt32(Console.ReadLine());
int res = 0, n = 999, i = 10, del = 1;

if (chislo > 99)
{
    while (res == 0)
    {
        if (chislo <= n)
        {
            res = chislo % i;
            res = res / del;
            Console.WriteLine("Третья цифра числа: " + res);
            break;
        }
        else
        {
            n = n * 10 + 9;
            i = i * 10;
            del = del * 10;
        }

    }
}
else
{
    Console.WriteLine("Третья цифра отсутствует");
}
