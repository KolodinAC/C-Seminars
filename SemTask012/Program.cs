// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// int[] array =


int N = InputInt();

int[] squaresTable = GetSquaresTab(N);

PrintArray(squaresTable);





int InputInt()
{
    System.Console.WriteLine("Введите желаемое целое число:");
    bool isNum = int.TryParse(Console.ReadLine(), out int N);
    if(isNum)
    {
        return N;
    }
    else
    {
        System.Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}

int[] GetSquaresTab(int N)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = (int)(Math.Pow(i+1, 2));
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int l = arr.Length;
    int i = 0;
    while (i < l)
    {
        Console.Write($"{arr[i]} ");
        i++;
    }
    Console.WriteLine();
}