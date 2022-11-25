// Написать пррограмму, которая на вход принимает номер дня недели и выдет его название.

Console.WriteLine("Enter the number of the day of the week:");

int number = int.Parse(Console.ReadLine());

if(number < 1 | number > 7)
{
    Console.WriteLine("Wrong number");
}

if(number == 1)
{
    Console.WriteLine("Monday");
}

if(number == 2)
{
    Console.WriteLine("Tuesday");
}

if(number == 3)
{
    Console.WriteLine("Wednesday");
}

if(number == 4)
{
    Console.WriteLine("Thursday");
}

if(number == 5)
{
    Console.WriteLine("Friday");
}

if(number == 6)
{
    Console.WriteLine("Saturday");
}

if(number == 7)
{
    Console.WriteLine("Sunday");
}
