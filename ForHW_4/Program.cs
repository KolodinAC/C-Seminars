// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int userLength = UserInputArrayLength();

int[] array = new int[userLength];

GetArrayFromUser();
PrintArray(array);



// Methods:

int UserInputArrayLength()
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

void GetArrayFromUser()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\nВведите элемент массива с индексом {i}:\t ");
        array[i] = int.Parse(Console.ReadLine());
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.WriteLine();
    Console.Write("Вывожу ваш массив: ");
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}
