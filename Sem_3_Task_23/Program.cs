// Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N 

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.WriteLine (message);
    return int.Parse (Console.ReadLine()??"0");
}
// Метод расчета
string LineBuilder (int N, int Pow)
{
    string resalt = string.Empty;
    for (int i = 1; i <= N; i++)
    {
        resalt = resalt + Math.Pow(i, Pow)+ "\t ";
    }
        return resalt;
}

// Метод вывода на экран результата 
int N = ReadData ("Enter N: ");
int Pow = ReadData ("Enter Pow: ");
Console.WriteLine (LineBuilder (N, 1));
Console.WriteLine (LineBuilder (N, Pow));