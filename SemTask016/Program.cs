// Задача 26: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

int userLength = UserInput();
int[] array = new int[userLength];
FillArray(array);
PrintArray(array);


// Methods:

int UserInput()
{
    System.Console.WriteLine("Введите длину массива:");
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);
    if (!isParsed || number < 1)
    {
        Console.WriteLine("Incorrect number");
        
    }
    return number;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}