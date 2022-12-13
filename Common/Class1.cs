namespace Common;
public static class Common
{
    static int UserInput(string msg)
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

    static int[] ReverseArray(int[] array)
    {
        int[] reversedArray = new int[array.Length];

        for (var i = 0; i < array.Length; i++)
        {
            reversedArray[i] = array[array.Length - 1 - i];
        }
        return reversedArray;
    }

    static int[] CreateRandomArray()
    {
        Random random = new Random();
        int[] array = new int[10];

        for (var i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(int.MinValue, int.MaxValue);
        }
        return array;
    }

    static void PrintArray(int[] collection)
    {
        Console.WriteLine("[{0}]", string.Join(", ", collection));
    }
}