    Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n<100 || n>1000)
    Console.WriteLine("Вы ввели не 3-х значное число"); 
else    
Console.WriteLine(n / 10 % 10);