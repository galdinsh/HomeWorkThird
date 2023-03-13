Console.Clear();
Console.Write("Введите день недели(от 1 до 7): ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите день недели(от 1 до 7): ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n >= 1 && n <= 5)
    Console.WriteLine("Это будни");
else
    Console.WriteLine("Это выходной");