// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями y = k1*x+b1 и y = k2*x+b2, при этом значения k1, b1, k2, b2 задает пользователь

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.Write (message);
    // Считываем число и парсим его 
    return int.Parse (Console.ReadLine()??"0");
}

// Метод проверки
(double resX, double resY) Intersectoin (double k1, double b1, double k2, double b2)
{
    double x = (b2-b1)/(k1-k2);
    double y = (k1*b2 - k2*b1)/(k1-k2);
return (x, y);
}
double k1 = ReadData ("Enter k1: ");
double b1 = ReadData ("Enter b1: ");
double k2 = ReadData ("Enter k2: ");
double b2 = ReadData ("Enter b2: ");

(double resultX, double resultY) ress= Intersectoin (k1, b1, k2, b2);
Console.WriteLine (ress);

