// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1



using static Common.Helper;

uint userNumber = UintInput("Введите желаемое количество чисел Фибоначчи: ");
uint[] fib = Fibonacci(userNumber);
PrintUintArray(fib);



uint[] Fibonacci(uint userNum)                  // метод создания массива с фибоначчи по кол-ву которое ввел пользователь 
{
    uint[] arr = new uint[userNum];
    
    if (!(userNum > 1)) return arr;
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < userNum; i++)
    {
        arr[i] = arr[i-1] + arr[i-2];
    }
    return arr;
}