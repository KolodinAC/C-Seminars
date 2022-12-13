// чтобы создать данный класс библиотеку нужно в терминале корневой папки написать команду - dotnet new classlib --name "название без ковычек"
// далее чтобы подключить данную библиотеку в проект нужно в терминале проекта написать - dotnet add reference "ссылка на файл название.csproj" - система должна ответить что подключено.
namespace Common;                             // создали неймспейс
public static class Helper                   // определили паблик(доступный для проектов) статик(содержащий статичные данные) класс и назвали Helper
{           // в тело класса положили регулярно нужные нам методы подписав к ним директивы как и у класса а именно - public и static 
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
            Console.WriteLine();
            Console.WriteLine("Вы ввели некорректное значение");
            return -1;
        }
    }

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

}