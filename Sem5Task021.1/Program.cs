// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве. 

int userLength = UserInput("Введите желаемую длину массива: ");

int[] userArray = GenerateArray(userLength);

Console.Write("Ваш массив:  ");

PrintArray(userArray);

int[] productArray = GenerateNewArray(userArray);

Console.Write("Новый массив:  ");

PrintArray(productArray);



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

int[] GenerateNewArray(int[] arr)
{
    int [] arr2 = new int[arr.Length/2 + arr.Length % 2];

    for (int i = 0; i < arr2.Length; i++)
    {
        if (i != arr.Length - i - 1)
        {
            arr2[i] = arr[i] * arr[arr.Length - i - 1];
        }
        else
        {
            arr2[i] = arr[i];
        }
    }
    return arr2;
}