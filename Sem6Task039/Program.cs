// Задача 39: Напишите программу, которая перевернёт 
//одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Console.WriteLine(int.MaxValue);
// int number;
// try
// {
//     number = InputNumber("Введите длину массива: ");
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine(ex.Message);
//     return;
// }
// int fdsfs = number + 1;


int[] array = CreateRandomArray();
PrintArray(array);
Console.WriteLine();
int[] reversed = ReverseArray(array);
PrintArray(reversed);

int InputNumber(string msg)
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

int[] ReverseArray(int[] array)
{
    int[] reversedArray = new int[array.Length];

    for (var i = 0; i < array.Length; i++)
    {
        reversedArray[i] = array[array.Length - 1 - i];
    }
    return reversedArray;
}

int[] CreateRandomArray()
{
    Random random = new Random();
    int[] array = new int[10];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(int.MinValue, int.MaxValue);
    }
    return array;
}

void PrintArray(int[] collection)
{
    Console.WriteLine("[{0}]", string.Join(", ", collection));
}