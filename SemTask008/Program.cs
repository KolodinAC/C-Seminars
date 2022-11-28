// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите два желаемых числа отличных от нуля:");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int sqa = b * b;
int sqb = a * a;

Console.WriteLine("");

if(sqa == a)
{
    Console.WriteLine($"1. Первое число {a} является квадратом второго числа {b}");
}
else 
{
    Console.WriteLine($"1. Первое число {a} не является квадратом второго числа {b}");
}

Console.WriteLine("");
Console.WriteLine("При этом:");
Console.WriteLine("");

if(sqb == b)
{
    Console.WriteLine($"2. Второе число {b} является квадратом первого числа {a}");
}
else 

{
    Console.WriteLine($"2. Второе число {b} не является квадратом первого числа {a}");
}