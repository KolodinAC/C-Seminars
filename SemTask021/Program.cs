// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве. 

int userLength = UserInput("Введите желаемую длину массива: ");

int[] userArray = GenerateArray(userLength);

Console.Write("Ваш массив:  ");

PrintArray(userArray);

GenerateNewArray(userArray);












int UserInput(string msg)
{
    Console.Write(msg);
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}

int[] GenerateArray(int userLength)
{
    Random random = new Random();
    int[] array = new int[userLength];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 9);
    }
    return array;
}

void PrintArray(int[] collection)
{
    Console.WriteLine("[{0}]", string.Join(", ", collection));
}

int[] GenerateNewArray(int[] array)
{
    int[] arrayB = new int[userLength / 2 + 1];
    int[] arrayC = new int[userLength / 2];

    if (userLength % 2 != 0)
    {

        for (int j = 0; j < array.Length / 2; j++)
        {
            int result = array[j] * array[userLength - 1];
            arrayB[j] = result;
            userLength = userLength - 1;
        }
        arrayB[userLength / 2 + 1] = array[array.Length / 2];
        Console.WriteLine($"Произведение пар чисел равно: {String.Join(", ", arrayB)}");
    }
    else
    {
        for (int j = 0; j < array.Length / 2; j++)
        {
            int result = array[j] * array[userLength - 1];
            arrayC[j] = result;
            userLength = userLength - 1;
        }
        Console.WriteLine($"Произведение пар чисел равно: {String.Join(", ", arrayC)}");
    }
    return array;
}