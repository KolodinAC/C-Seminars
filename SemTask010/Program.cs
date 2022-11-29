// Напишите программу, которая принимает на ввод координаты точки (X и Y), причем X =/= 0 и Y =/= 0 
// и выдает номер четверти плоскости, в катоторой находится эта точка.

Console.WriteLine("Введиет значение координат X и Y");

bool isParsedX = int.TryParse(Console.ReadLine(), out int x); // проводим проверку ввел ли пользователь цифры или буквы

bool isPArsedY = int.TryParse(Console.ReadLine(), out int y); // проводим проверку ввел ли пользователь цифры или буквы

if(!isParsedX || !isPArsedY) // не должно быть букв или нолей так как вводятся координаты осей X и Y
{
    Console.WriteLine("Координаты введены не корректно");
    return;                                              // обязательно прерываем цикл с помощью пустого return
}

int quarterNumber = GetQuarterNumberByCoordinates(x,y);
if(quarterNumber == - 1)
{
    Console.WriteLine("Координаты равны нулю");
    return;
}

Console.WriteLine(quarterNumber);

// МЕТОДЫ: 

//  возвращаемый_тип_данных(int, duble итд) НазваниеМетода(параметры методы - с чем работает например целочисленные координаты)
//  {
//       return 1; (что вернуть)          // оператор return возвращает из метода значение и останавливает метод
//  }

// Пример метода - метод который определяет номер четверти координатной плоскости по двум введенным координатам:


int GetQuarterNumberByCoordinates(int x, int y)
{
    if(x > 0 && y > 0)
    {
        return 1;
    }

    if(x < 0 && y > 0)
    {
        return 2;
    }

    if(x < 0 && y < 0)
    {
        return 3;
    }

    if(x > 0 && y < 0)
    {
        return 4;
    }

    return -1;
}