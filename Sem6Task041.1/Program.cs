// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101

// Решение через строку - десятичное число переводится в двоичное в виде строки:


using static Common.Helper;

int numDec = UserInput("Введите десятичное число для преобразования в двоичное: ");
string res = DecToBin(numDec);
System.Console.WriteLine("Ваше число в двоичной системе: " + res);

string DecToBin(int num) // метод записывает результат в виде строки
{
    string binNum = string.Empty;
    
    while(num != 0)
    {
       binNum = num % 2 + binNum;
       num = num / 2; 
    }
    return binNum;
}