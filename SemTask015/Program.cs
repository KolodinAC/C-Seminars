// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.



int number = UserUnput();

int result = GetProdOfNumbersInInterval(number);

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
    int prod = 1;
    for (var i = 1; i <= number; i++)
    {
        prod = prod * i;
    }
    return prod;
}