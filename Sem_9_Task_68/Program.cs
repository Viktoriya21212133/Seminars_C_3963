// Напишите программувычисления функции Аккермана с помощью рекурси. Даны два неотрицательных числа m и n

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.Write (message);
    // Считываем число и парсим его 
    return int.Parse (Console.ReadLine()??"0");
}

// метод вывода результатов
void PrintResult (int message)
{
    Console.WriteLine (message);
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
// Вызов метода
int number1 = ReadData ("Enter your number m: ");
int nunber2 = ReadData ("Enter your number n: ");
int result = Akkerman (number1,nunber2);
PrintResult (result);