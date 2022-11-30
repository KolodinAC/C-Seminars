// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 2D пространстве.

int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());

int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());

double result = GetDistanceBetweenTwoPoints(x1, y1, x2, y2); 
Console.WriteLine(result);

double GetDistanceBetweenTwoPoints(int x1, int y1, int x2, int y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)), 2);
}