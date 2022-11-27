// Написать программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает первую цифру числа(надо разделить на 10 чтоб округлилось), 
//последнюю цифру(надо посмотреть остаток от деления на 10)и наибольшую цифру числа.

Random random = new Random();

int number = random.Next(10, 100);

Console.WriteLine(number);

int firstNumber = number / 10;
int lastNumber = number % 10;

if(firstNumber > lastNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(lastNumber);
}