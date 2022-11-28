// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.WriteLine("Введите два желаемых числа отличных от нуля:");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int rest = a % b;

if(rest == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.Write("Второе число не кратно первому, остаток ");
    Console.WriteLine(rest);
}