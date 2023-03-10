// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями y = k1*x+b1 и y = k2*x+b2, при этом значения k1, b1, k2, b2 задает пользователь

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.Write (message);
    // Считываем число и парсим его 
    return int.Parse (Console.ReadLine()??"0");
}

// Метод проверки
(double resX, double resY) Intersectoin (int k1, int b1, int k2, int b2)
{
    double y= 0;
    //double x= new double();
    //x = (y-b1)/k1;
    //y = k2*x+b2;
    double x = ((k2*y-k2*b1)/k1)+b2;
    y = (x-b1)/k1;
return (x, y);
}
int k1 = ReadData ("Enter k1: ");
int b1 = ReadData ("Enter b1: ");
int k2 = ReadData ("Enter k2: ");
int b2 = ReadData ("Enter b2: ");

(double resultX, double resultY) ress= Intersectoin (k1, b1, k2, b2);
Console.WriteLine (ress);

