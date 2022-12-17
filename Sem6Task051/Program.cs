// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1; 1) и т.д.

using static Common.Helper;

int m = UserInput("Введите желаемое количество строк массива: ");
int n = UserInput("Введите желаемое количество столбцов массива: ");

int[,] newArray = CreateRandom2DArray(m, n);
Print2DArray(newArray);
