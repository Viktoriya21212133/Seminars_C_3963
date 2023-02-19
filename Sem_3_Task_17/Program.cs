// Напишите программу, которая принимает на вход координаты точки (х,у), причем х не равно у, и выдает номер четверти плоскости, в которой находится эта точка

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.WriteLine (message);
    return int.Parse (Console.ReadLine()??"0");
}

// Объявляем переменные
int CoordX = ReadData ("Enter X: ");
int CoordY = ReadData ("Enter Y: ");

// Метод, который ничего не вернет, но определит четверть
void PrintQuarterTest(int X, int Y)
{
    if (X > 0 && Y > 0) Console.WriteLine ("first quarter point");
    if (X > 0 && Y < 0) Console.WriteLine ("second quarter point");
    if (X < 0 && Y > 0) Console.WriteLine ("third quarter point");
    if (X < 0 && Y < 0) Console.WriteLine ("fourth quarter point");
}

// Обращаемся к методу
PrintQuarterTest (CoordX, CoordY);