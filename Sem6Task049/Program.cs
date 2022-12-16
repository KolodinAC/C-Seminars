// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, 
// и замените эти элементы на их квадраты.



using static Common.Helper;

int m = UserInput("Введите желаемое количество строк массива: ");
int n = UserInput("Введите желаемое количество столбцов массива: ");

int[,] newArray = CreateRandom2DArray(m, n);
Print2DArray(newArray);
int[,] arr = GetSquareForUneven(newArray);
System.Console.WriteLine();
Print2DArray(arr);

int[,] GetSquareForUneven(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (i % 2 != 0)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (j % 2 != 0)
                {
                    matr[i, j] = (int)(Math.Pow(matr[i, j], 2));
                }
            }
        }
    }
    return matr;
}