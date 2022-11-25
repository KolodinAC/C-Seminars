// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

int N = int.Parse(Console.ReadLine());
int i = -N;

if(N < 0)
{
    Console.WriteLine("Enter only positive numbers!");
}
while(i <= N)
{
    Console.Write(i);
    i++;
}