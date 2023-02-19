// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между этими двумя точками в ТРЕХМЕРНОМ пространстве

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.WriteLine (message);
    return int.Parse (Console.ReadLine()??"0");
}

// Объявляем переменные х и у
int X1 = ReadData ("Enter X1: ");
int Y1 = ReadData ("Enter Y1: ");
int Z1 = ReadData ("Enter Z1: ");
int X2 = ReadData ("Enter X2: ");
int Y2 = ReadData ("Enter Y2: ");
int Z2 = ReadData ("Enter Z2: ");

// Метод, который ничего не вернет, но выведет результат
void PrintData (string message, double res)
{
    Console.WriteLine (message+res);
}

// метод, который будет считать расстояние
double CalcLan2D (int X1, int Y1, int X2, int Y2, int Z1, int Z2)
{
    return Math.Sqrt((X1-X2)*(X1-X2)+(Y2-Y1)*(Y2-Y1)+(Z2-Z1)*(Z2-Z1));
}

// Обращаемся к методу
double Resalt = CalcLan2D (X1, Y1, X2, Y2, Z1, Z2);
PrintData("Resalt: ", Resalt);

