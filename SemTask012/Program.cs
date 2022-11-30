// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// int[] array =

Console.WriteLine("Введите желаемое число");

int N = int.Parse(Console.ReadLine());

int[] squaresTable = GetSquaresTab(N);

PrintArray(squaresTable);

int[] GetSquaresTab(int N)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = (int)(Math.Pow(i+1, 2));
    }
    return arr;
}

void PrintArray (int[] arr)
{
    int l = arr.Length;
    int i = 0;
    while (i < l)
    {
        Console.Write($" {arr[i]}");
        i++;
    }
}