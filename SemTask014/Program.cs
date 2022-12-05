// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.



int number = UserUnput();

int product = GetProdOfNumbersInInterval(number);

Console.WriteLine(product);


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

int GetProdOfNumbersInInterval(int number)
{
    int prod = 1;
    for (var i = 1; i <= number; i++)
    {
        prod = prod * i;
    }
    return prod;
}