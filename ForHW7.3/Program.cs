// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

using static Common.Helper;


Console.WriteLine();
int m = UserInput("Введите желаемое количество строк массива: ");
int n = UserInput("Введите желаемое количество столбцов массива: ");
Console.WriteLine();

int[,] newArray = CreateRandom2DArray(m, n);
Console.WriteLine("Сгенерированный массив: ");
Print2DArray(newArray);
Console.WriteLine();

Console.Write("Среднее арифметическое элементов в столбцах массива: ");
GetArithMFromColumns(newArray);
Console.WriteLine();

float GetArithMFromColumns(int[,] matr)
{
    float avarage = 0;
    float colSum = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            colSum = (colSum + matr[i, j]);
        }
        avarage = colSum / n;
        Console.Write(avarage + "; ");
    }
    Console.WriteLine();
    return avarage;
}
