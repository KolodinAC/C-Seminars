// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.


Console.WriteLine("Введите желаемое число отличное от нуля:");

int number = int.Parse(Console.ReadLine());
int a = 7;
int b = 23;
int rest = (number % a) + (number % b);

if(rest == 0)
{
    Console.WriteLine("Ваше число кратно 7 и 23.");
}
else
{
    Console.WriteLine("Ваше число не кратно 7 и 23, остаток ");
    Console.WriteLine(rest);
}