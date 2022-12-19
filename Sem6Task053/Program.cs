// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

using static Common.Helper;

int m = UserInput("Введите желаемое количество строк массива: ");
int n = UserInput("Введите желаемое количество столбцов массива: ");

int[,] newArray = CreateRandom2DArray(m, n);
Print2DArray(newArray);
System.Console.WriteLine();
int[,] changedArray = ChangeLinesInArray(newArray);
Print2DArray(changedArray);




int[,] ChangeLinesInArray(int[,] matr)
{
    int rows = matr.GetLength(0);
    int columns = matr.GetLength(1);
    int[,] array = new int[rows, columns];

    for (int i = 1; i < rows-1; i++)
    {
        for (int j = 0; i < columns; j++)
        {
            array[i,j] = matr[i,j];
        }
    }
    for (int j = 0; j < columns; j++)
    {
        array[0, j] = matr[rows-1, j];
        array[rows-1, j] = matr[0,j];
    }
    return array;
}