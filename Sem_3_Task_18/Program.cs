// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат в этой четверти

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.WriteLine (message);
    return int.Parse (Console.ReadLine()??"0");
}

// Объявляем переменные
int NumberPoint = ReadData ("Enter number point: ");

if (NumberPoint>0 && NumberPoint<5)
{
// Метод, который ничего не вернет, но определит четверть
void PrintCoordinats (int number)
{
    if (number == 1) Console.WriteLine ("X > 0 && Y > 0");
    if (number == 2) Console.WriteLine ("X > 0 && Y < 0");
    if (number == 3) Console.WriteLine ("X < 0 && Y > 0");
    if (number == 4) Console.WriteLine ("X < 0 && Y < 0");
}

// Обращаемся к методу
PrintCoordinats (NumberPoint);
}
else
Console.WriteLine ("Error!");