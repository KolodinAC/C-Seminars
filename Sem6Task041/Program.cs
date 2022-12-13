// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101


using static Common.Helper;

int numDec = UserInput("Введите десятичное число для преобразования в двоичное: ");
int numBin = GetBinaryFromDecimal(numDec);
Console.WriteLine(numBin);


int GetBinaryFromDecimal(int num)
{
    int newNum = 0;
    while (num > 0)
    {
        int rest = num % 2;
        newNum = newNum * 10 + rest;
        num = num / 10;  
    }
    return newNum;
}