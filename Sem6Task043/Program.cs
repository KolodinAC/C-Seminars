// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью


using static Common.Helper;

int userLength = UserInput("Введите желаемую длину массива: ");
int[] mynewArr = CreateRandomArray(userLength);
PrintArray(mynewArr);
System.Console.WriteLine();
int[] myArrCopy = CopyArray(mynewArr);
System.Console.WriteLine("Копия вашего массива: ");
PrintArray(myArrCopy);

// int[] CopyArray(int[] array)      // закомментировал данный метод так как поместил его в библиотеку Common
// {
//     int[] arrCopy = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         arrCopy[i] = array[i];
//     }
//     return arrCopy;
// }