// чтобы создать данный класс библиотеку нужно в терминале корневой папки написать команду - dotnet new classlib --name "название без ковычек"
// далее чтобы подключить данную библиотеку в проект нужно в терминале проекта написать - dotnet add reference "ссылка на файл название.csproj" - система должна ответить что подключено.
namespace Common;                             // создали неймспейс
public static class Helper                   // определили паблик(доступный для проектов) статик(содержащий статичные данные) класс и назвали Helper

{           // в тело класса положили регулярно нужные нам методы подписав к ним директивы как и у класса а именно - public и static 


// Получение и проверка данных от пользователя:
    public static int UserInput(string msg)
    {
        Console.Write(msg);
        bool isNum = int.TryParse(Console.ReadLine(), out int num);
        if (isNum)
        {
            return num;
        }
        else
        {
            throw new Exception("Вы ввели неправильное число!");             // чтобы в процессе работы программы показать пользователю что он не то вводит мы можем "выбросить исключение"
        }
    }

    public static uint UintInput(string msg)     // версия для типа данных uint - тоесть тоже что инт только входят положительные целые числа
    {
        Console.Write(msg);
        bool isNum = uint.TryParse(Console.ReadLine(), out uint num);
        if (isNum)
        {
            return num;
        }
        else
        {
            throw new Exception("Вы ввели неправильное число!");             // чтобы в процессе работы программы показать пользователю что он не то вводит мы можем "выбросить исключение"
        }
    }

// Работы с массивами:
    public static int[] ReverseArray(int[] array)
    {
        int[] reversedArray = new int[array.Length];

        for (var i = 0; i < array.Length; i++)
        {
            reversedArray[i] = array[array.Length - 1 - i];
        }
        return reversedArray;
    }

    public static int[] CreateRandomArray()
    {
        Random random = new Random();
        int[] array = new int[10];

        for (var i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-100, 101);
        }
        return array;
    }

    public static void PrintArray(int[] collection)
    {
        Console.WriteLine("[{0}]", string.Join(", ", collection));
    }

    public static void PrintUintArray(uint[] collection)     // печать массива на основе uint (тобишь только с положительными целыми числами)
    {
        Console.WriteLine("[{0}]", string.Join(", ", collection));
    }

// Разное: 
    public static int[] GetBinaryFromDecimal(int num)    // метод позволяет преобразовать число из десятичной системы в двоичную в виде массива
    {
        int numRange = 0;
        int numTemp = num;
        while (numTemp > 0)
        {
            numTemp = numTemp / 2;
            numRange++;
        }
        int length = numRange;
        int[] arr = new int[length];
        for (int i = length - 1; i >= 0; i--)
        {
            arr[i] = num % 2;
            num = num / 2;
        }
        return arr;
    }

    public static uint[] Fibonacci(uint userNum)                  // метод создания массива с фибоначчи по кол-ву которое ввел пользователь 
    {
        uint[] arr = new uint[userNum];

        if (!(userNum > 1)) return arr;
        arr[0] = 0;
        arr[1] = 1;
        for (int i = 2; i < userNum; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2];
        }
        return arr;
    }
}