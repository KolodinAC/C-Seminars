// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

using static Common.Helper;

uint m = UintInput("Введите желаемое количество строк массива: ");
uint n = UintInput("Введите желаемое количество столбцов массива: ");

float[,] newArray = CreateRandom2DArrayF(m, n);
Print2DArrayF(newArray);