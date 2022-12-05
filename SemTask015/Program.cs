// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.



int number = UserUnput();

int result = GetCountOfDigits(number);

Console.WriteLine(result);


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

int GetCountOfDigits(int number)
{
    int count = 0;
    while (number != 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}