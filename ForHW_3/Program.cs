// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
// Задание должно быть выполнено в методе и метод должен вернуть массив чисел.

int N = InputInt();

int[] cubesTable = GetCubesTab(N);

PrintArray(cubesTable);










































int InputInt()
{
    Console.WriteLine("Введите желаемое целое число:");
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

int[] GetCubesTab(int N)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = (int)(Math.Pow(i+1, 3));
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