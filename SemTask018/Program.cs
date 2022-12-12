// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
// отрицательные, и наоборот.

int userLength = UserInput();

float[] userArray = GenerateArray(userLength);

Console.Write("Ваш массив:  ");

PrintArray(userArray);

userArray = ChangeNegativeToPositive(userArray);

Console.Write("Ваш массив после замены отрицательных чисел на положительные:  ");

PrintArray(userArray);







int UserInput()
{
    Console.Write("Введите желаемый размер массива:\t");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum && num > 0)
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

float[] GenerateArray(int userLength)
{
    Random random = new Random();
    float[] array = new float[userLength];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 101);
    }
    return array;
}

void PrintArray(float[] collection)
{
    Console.WriteLine("[{0}]", string.Join(", ", collection));
}

float[] ChangeNegativeToPositive(float[] collection)
{
    float temp = 0;
    for (int index = 0; index < collection.Length; index++)
    {
        if (collection[index] < 0)
        {
            collection[index] = collection[index] * -1;
        }
    }
    return collection;
}