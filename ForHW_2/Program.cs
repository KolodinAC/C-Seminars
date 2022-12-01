// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
// Задание должно быть выполнено в методе. 
// В методе не должно быть вывода в консоль.

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


int x1 = UserInput();
int y1 = UserInput();
int z1 = UserInput();
int x2 = UserInput();
int y2 = UserInput();
int z2 = UserInput();
int x3 = UserInput();
int y3 = UserInput();
int z3 = UserInput();