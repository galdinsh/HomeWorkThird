﻿Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 999 )
{
    n = n / 10;
}
if (n<100)
Console.WriteLine("Третьего числа нет");
else
Console.WriteLine(n % 10);
