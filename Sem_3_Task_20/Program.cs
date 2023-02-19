// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между этими двумя точками в ДВУХМЕРНОМ мерном пространстве

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.WriteLine (message);
    return int.Parse (Console.ReadLine()??"0");
}

// Объявляем переменные х и у
int CoordinateX1 = ReadData ("Enter X1: ");
int CoordinateY1 = ReadData ("Enter Y1: ");
int CoordinateX2 = ReadData ("Enter X2: ");
int CoordinateY2 = ReadData ("Enter Y2: ");


// Метод, который ничего не вернет, но выведет результат
void PrintData (string message, double res)
{
    Console.WriteLine (message+res);
}

// метод, который будет считать расстояние
double CalcLan2D (int CoordinateX1, int CoordinateY1, int CoordinateX2, int CoordinateY2)
{
    return Math.Sqrt ((CoordinateX1-CoordinateX2)*(CoordinateX1-CoordinateX2)+(CoordinateY1-CoordinateY2)*(CoordinateY1-CoordinateY2));
}

// Обращаемся к методу
double Resalt = CalcLan2D (CoordinateX1, CoordinateY1, CoordinateX2, CoordinateY2);
PrintData("Resalt: ", Resalt);

