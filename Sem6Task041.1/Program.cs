// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101

// Решение через строку - десятичное число переводится в двоичное в виде строки:


using static Common.Helper;

// ! Для отлавливания ошибок используется способ с помещением блока кода где может вылететь ошибка в код Try, например:

int numDec; // переменную надо объявить до try иначе переменная не будет доступна в коде

try
{
    numDec = UserInput("Введите десятичное число для преобразования в двоичное: ");
}
catch(Exception ex)
{
    System.Console.WriteLine(ex.Message);
    return;
}


string res = DecToBin(numDec);
Console.WriteLine("Ваше число в двоичной системе: " + res);

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