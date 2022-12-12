// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
// отрицательные, и наоборот.

int userLength = UserInput("Введите желаемую длину массива: ");

float[] userArray = GenerateArray(userLength);

Console.Write("Ваш массив:  ");

PrintArray(userArray);

float findNum = UserInput("Введите число для поиска: ");

bool findResult = FindUserNumber(userArray, findNum);

if(findResult == true)
{
    Console.WriteLine("Ваше число содержится в массиве");
}
else
{
    Console.WriteLine("Вашего числа нет в массиве");
}









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

bool FindUserNumber(float[] collection, float find)
{
    for (int index = 0; index < collection.Length; index++)
    {
        if (collection[index] == find)
        {
            return true;
        }
    }
    return false;
}