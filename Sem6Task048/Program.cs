// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m+n. 
// Выведите полученный массив на экран. m = 3, n = 4.


using static Common.Helper;

int[,] matrix = new int[3, 4];
FillTwoDimArray(matrix);
PrintTwoDimArray(matrix);



void FillTwoDimArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintTwoDimArray(int[,] matr)           
{
    for (int i = 0; i < matr.GetLength(0); i++)           
    {
        for (int j = 0; j < matr.GetLength(1); j++)      
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
