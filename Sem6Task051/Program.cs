// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1; 1) и т.д.

using static Common.Helper;

int m = UserInput("Введите желаемое количество строк массива: ");
int n = UserInput("Введите желаемое количество столбцов массива: ");

int[,] newArray = CreateRandom2DArray(m, n);
Print2DArray(newArray);
System.Console.WriteLine();
int sumOfElem = GetSumOfMainDiag(newArray);
System.Console.Write("Сумма элементов по главной диагонали составляет: ");
System.Console.WriteLine(sumOfElem);





int GetSumOfMainDiag(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matr[i, j];
            }
        }
    }
    return sum;
}
