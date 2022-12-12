// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

float[] userArray = GenerateArray(123);

PrintArray(userArray);

int countOfNum = GetCountOfNumbFromSegment(userArray);

Console.WriteLine(countOfNum);



float[] GenerateArray(int userLength)
{
    Random random = new Random();
    float[] array = new float[userLength];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, userLength);
    }
    return array;
}

void PrintArray(float[] collection)
{
    Console.WriteLine("[{0}]", string.Join(", ", collection));
}

int GetCountOfNumbFromSegment(float[] collection)
{
    int count = 0;
    for (int index = 0; index < collection.Length; index++)
    {
        if(collection[index] >= 10 & collection[index] <= 99)
        {
            count++;
        }
    }
    return count;
}