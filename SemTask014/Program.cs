// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.



double number = UserInput();

double product = GetProdOfNumbersInterval(number);

Console.WriteLine(product);


double UserInput()
{
    System.Console.WriteLine("Введите число:");
    bool isParsed = double.TryParse(Console.ReadLine(), out double number);
    if (!isParsed || number < 1)
    {
        Console.WriteLine("Incorrect number");
        
    }
    return number;
}

double GetProdOfNumbersInterval(double number)
{
    double prod = 1;
    for (var i = 1; i <= number; i++)
    {
        prod = prod * i;
    }
    return prod;
}