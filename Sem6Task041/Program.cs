// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101

// Решение через массив - десятичное число возвращается в виде массива:


using static Common.Helper;

int numDec = UserInput("Введите десятичное число для преобразования в двоичное: ");
int[] numBin = GetBinaryFromDecimal(numDec);
Console.Write("Ваше число в двоичной системе: ");
PrintArray(numBin);





int[] GetBinaryFromDecimal(int num)
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