// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// using static Console;  // таким образом не нужно будет приписывать команду Console. например - Console.WriteLine можно просто WriteLine


Console.WriteLine("Введите номер координатной четверти");

bool isParsed = int.TryParse(Console.ReadLine(), out int quarterNumber);
if(!isParsed)
{
    Console.WriteLine("Вы ввели некорректное значение");
    return -1;
}
else
{
    return quarterNumber;
} 
int xycoordinates = 0;
Console.WriteLine(GetCoordinats(xycoordinates));


string GetCoordinats(int quarterNumber)
{
    if (quarterNumber == 1)
    {
        return ("x > 0, y > 0");
    }

    if(quarterNumber == 2)
    {
        return ("x < 0, y > 0");
    }

    if(quarterNumber == 3)
    {
        return ("x < 0, y < 0");
    }

    if(quarterNumber == 4)
    {
        return ("x > 0, y < 0");
    }
    return "Неправильный запрос";
}