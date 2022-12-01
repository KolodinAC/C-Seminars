// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. 
// Не использовать String!

int num = UserInput();

int rev = CheckPalindrome(num);

PrintAnswer(rev);

// Методы:

int UserInput()
{
    Console.WriteLine("Введите любое пятизначное число:");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    // if(isNum && num > 9999 && num < 100000)
    if(isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
     
}

int CheckPalindrome(int num)
{
    int n = num;
    int rev = 0;
    int result;
    while(n > 0)
    {
        int r = n % 10;
        rev = rev * 10 + r;
        n = n / 10;
    }
    return rev;
}

int PrintAnswer(int rev)
{
    if(rev == num)
    {
        Console.WriteLine($"Введенное Вами число является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Введенное Вами число не является палиндромом.");
    }
    return -1;
}