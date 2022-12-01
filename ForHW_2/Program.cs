// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
// Задание должно быть выполнено в методе. 
// В методе не должно быть вывода в консоль.

int x1 = UserInput();
int y1 = UserInput();
int z1 = UserInput();
int x2 = UserInput();
int y2 = UserInput();
int z2 = UserInput();

double result = GetDistanceBetweenTwoPoints(x1, y1, z1, x2, y2, z2); 

Console.WriteLine(result);



































int UserInput()
{
    Console.WriteLine("Введите координаты заданных точек:");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if(isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректные значения");
        return -1;
    }
     
}

double GetDistanceBetweenTwoPoints(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)), 2);
}