// Задайте значения m и n. Напишите программу, которая найдет все натуральные элементы в промежутке от m до n

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

// функция сумма чисел от M до N
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m+SumMN(m,n);
        return res;
    }
}

int number1 = ReadData ("Enter your number m: ");
int nunber2 = ReadData ("Enter your number n: ");
int result = SumMN (number1-1,nunber2);
PrintResult (result);