// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// using static Console;  // таким образом не нужно будет приписывать команду Console. например - Console.WriteLine можно просто WriteLine


Console.WriteLine("Введите номер координатной четверти");

int qNum = int.Parse(Console.ReadLine());

// bool isParsed = int.TryParse(Console.ReadLine(), out int qNum);
// if(!isParsed)
// {
//     Console.WriteLine("Введены не корректные данные, пожалуйста введите цифры от 1 до 4");
//     return -1;
// }
// else
// {
//     return qNum;
// }

string xycoordinates = GetCoordinatesByQNum(qNum);
Console.WriteLine(xycoordinates);


string GetCoordinatesByQNum(int qNum)
{
    if (qNum == 1)
    {
        return ("x > 0, y > 0");
    }

    if(qNum == 2)
    {
        return ("x < 0, y > 0");
    }

    if(qNum == 3)
    {
        return ("x < 0, y < 0");
    }

    if(qNum == 4)
    {
        return ("x > 0, y < 0");
    }
    return "Неправильный запрос";
}