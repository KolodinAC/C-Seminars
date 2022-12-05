//Задача 24: Напишите программу, которая принимает на вход число
// (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28 4 -> 10 8 -> 36
/*bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed || number < 1)
{
    Console.WriteLine("Incorrect number");
    return;
}

int sum = GetSumOfNumbersInInterval(number);
Console.WriteLine(sum);*/

void TestPositiveGetSumOfNumbersInInterval()
{
    int[] numbers = new int[] { 1, 2, 3, 4 };

    int[] expected = new int[] { 1, 3, 6, 10 };

    for (var i = 0; i < numbers.Length; i++)
    {
        int actual = GetSumOfNumbersInInterval(numbers[i]);

        if (actual != expected[i])
        {
            Console.WriteLine($"Ожидали получить {expected[i]} а получили {actual}");
        }
        else
        {
            Console.WriteLine("okay");
        }
    }
}

// void Test()
// {
//     int[] lengths = new int[] { 1, 2, 3, 4 };

//     int[] expected = new int[] { 1, 2, 3, 4 };

//     for (var i = 0; i < lengths.Length; i++)
//     {
//         int[] actual = Fill(lengths[i]);
//         if (expected[i] == actual.Length)
//         {

//         }
//     }
// }

int result = GetSumOfNumbersInInterval(number);

int GetSumOfNumbersInInterval(int number)
{
    int sum = 0;
    for (var i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}