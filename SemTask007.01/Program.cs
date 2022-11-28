// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.


Console.WriteLine("Введите желаемое число отличное от нуля:");

bool isParsed = int.TryParse(Console.ReadLine(), out int number); // проверка на то ввели ли пользователь цифры или же по ошибке буквы. TryParse проверяет возможность считать цифры. bool задает переменную isParsed которая принимает значения True если получилось считать цифры или False если пользователь ввел вместо цифр буквы и система не смогла их считать.
//int number = int.Parse(Console.ReadLine());

if(!isParsed)
{
    Console.WriteLine("Введено неправильное значение, вводите числа!");
}
else
{
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
}