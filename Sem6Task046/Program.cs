//Задача 46: Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами.
//m = 3, n = 4. 

using static Common.Helper;

// Создаем метод для создания рандомного 2д массива

// int[,] array = CreateRandom2DArray(3, 4);        // создаем пустой массив для заполнения с размерностью 3 строки и 4 столбца и передаем его в наш метод для заполнения рандомными числами
// Print2DArray(array);


// Картежи: чтобы вывести две переменные и не в виде массива

// (int, int, string) coordinates = GetSomething();    // заводим двойную переменную чтобы положить в нее результат метода в виде 2 координат 

// System.Console.Write(coordinates.Item1);
// System.Console.Write(", " + coordinates.Item2);
// System.Console.WriteLine(", " + coordinates.Item3);


// (int, int, string) GetSomething()                  // указываем в методе тип данных - два числа int через запятую, а вообще можно в скобки засунуть кучу разных типов данныз вместе
// {
//     int a = 5;                             // получаем значения в переменных из другого метода итп
//     int b = 10;
//     string t = "Fuck you asshole!";

//     return (a, b, t);                        // возвращаем переменные которые соответствуют всем типам данных в скобках в заголовке метода, все типы данных должны быть возвращены
// }

// Работа со строками:

int[] array = new int[3]{1, 2, 3};  // к примеру имеем массив и нам надо вывести его значения в строку

string.Join(",", array);  // 




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