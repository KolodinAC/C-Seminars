// Написать пррограмму, которая на вход принимает два числа и проверяет является ли первое число квадратом второго.

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

if(number1 == number2 * number2)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}