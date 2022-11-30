// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 2D пространстве.

double InputCheck(){
    Console.WriteLine("Введите координаты двух точек на плоскости (ax ay, bx by)");

    bool isNum = double.TryParse(Console.ReadLine(), out double num);

    if(isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректные значения координат");
        return -1;
    }
}



double ax = InputCheck();
double ay = InputCheck();
double bx = InputCheck();
double by = InputCheck();

double ab = Math.Sqrt((bx-ax)*(bx-ax) + (by-ay)*(by-ay)); 

Console.WriteLine(ab);