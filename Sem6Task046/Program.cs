//Задача 46: Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами.
//m = 3, n = 4. 

using static Common.Helper;

// Создаем метод для создания рандомного 2д массива

int[,] array = CreateRandom2DArray(3, 4);        // создаем пустой массив для заполнения с размерностью 3 строки и 4 столбца и передаем его в наш метод для заполнения рандомными числами
Print2DArray(array);




// int[,] CreateRandom2DArray(int countOfRows, int countOfColumns)
// {
//     Random random = new Random();
//     int[,] array = new int[countOfRows, countOfColumns];

//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(-10, 11);
//         }
//     }
//     return array;
// }