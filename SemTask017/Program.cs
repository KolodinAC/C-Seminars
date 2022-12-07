// Демонстрация решения
// Задача 31: Задайте массив из 12 элементов,
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

string str = "Bla {0}, Bla {1}, Bla {2}"; // задаем шаблон строчек и потом их везде используем в коде ниже (см строку №19)


int[] array = GenerateArray(-9, 9, 12); // задали методу мин макс и длину и получившийся массив положили в переменную массива array
PrintArray(array);                     // вывели полученный массив в консоль для наглядности

int sumPositiveNumbers = GetSumPositiveNumbersInArray(array); // передали методу наш массив и результат сложения положили в переменную
int sumNegativeNumbers = GetSumNegativeNumbersInArray(array); // передали методу наш массив и результат сложения положили в переменную

Console.WriteLine($"Сумма положительных чисел равна {sumPositiveNumbers}, сумма отрицательных равна {sumNegativeNumbers}.");

Console.WriteLine(str, "x", "y", "z"); // продолжение со строки 8 - после того как задали шабло можем вызвать инфо из него указав в параметре переменную шаблона, затем после запятой что вставить в шаблон

// int[] a = new int[4]{1,2,34,5};
// a.Contains(12);



// Methods:

int[] GenerateArray(int min, int max, int length) // метод генерирует массив рандомных чисел из заданного диапазона от min до max и имеет заданную длину
{
    Random random = new Random();  // создаем объект рандом чтобы его можно было в последствии использовать несколько раз иначе одноразовая функция получится
    int[] array = new int[length];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

int GetSumPositiveNumbersInArray(int[] collection) // метод вычленяет из массива положительные числа и суммирует их
{
    int sumPositiveNumbers = 0;
    for (var i = 0; i < collection.Length; i++)
    {
        if (collection[i] >= 0)
        {
            sumPositiveNumbers += collection[i];
        }
    }
    return sumPositiveNumbers;
}

int GetSumNegativeNumbersInArray(int[] collection) // метод вычленяет из массива положительные числа и суммирует их
{
    {
        int sumNegativeNumbers = 0;
        for (var i = 0; i < collection.Length; i++)
        {
            if (collection[i] < 0)
            {
                sumNegativeNumbers += collection[i];
            }
        }
        return sumNegativeNumbers;
    }
}

void PrintArray(int[] collection)
{
    // for (var i = 0; i < collection.Length; i++)  |
    // {                                            |  это стандартный вариант как вывести массив в печать
    //     Console.Write("{collection[i]}");        | 
    // }

    // string message = string.Join(" ,", collection);  | создаем переменную типа данных строка и в нее кладем string.Join, а потом ее уже выводим на печать
    // Console.WriteLine(message);                      |

    // Console.WriteLine($"[{string.Join(", ", collection)}]"); // это базовый варинт где мы помещаем переменные и string.Join внутрь текста в кавычках, метод Join называется - Сепартор тк разделяет символами строку
    Console.WriteLine("[{0}]",string.Join(", ", collection)); // string.Join создает из массива строку, первый агрумент является разделительным знаком между элементами (в данном случае запятая), второй аргумент это сам массив, а ноль в начале строки в скобках показывает куда поставить следующую за ним конструкцию string.Join
}
