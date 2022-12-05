//Задача 24: Напишите программу, которая принимает на вход число
// (А) и выдаёт сумму чисел от 1 до А.


int number = UserUnput();
int sum = GetSumOfNumbersInInterval(number);
Console.WriteLine(sum);


int UserUnput()
{
    System.Console.WriteLine("Введите число:");
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);
    if (!isParsed || number < 1)
    {
        Console.WriteLine("Incorrect number");
        
    }
    return number;
}

int GetSumOfNumbersInInterval(int number)
{
    int sum = 0;
    for (var i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}