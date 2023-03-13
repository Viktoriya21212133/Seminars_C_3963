// Задайте значение N и напишите программу, которая выведет все натуральные числа в промежутке от 1 до N . Выполнить с помощью рекурсии

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.Write (message);
    // Считываем число и парсим его 
    return int.Parse (Console.ReadLine()??"0");
}

// метод вывода результатов
void PrintResult (string message)
{
    Console.WriteLine (message);
}

// Метод генерации рекурсии
string LineGenRec (int m, int n)
{
    string res = string.Empty;
        if (m>=n)
        {
        res = n.ToString();
        }
        else
        {
        res = res+m+" "+LineGenRec(m+1,n);
        }
return res;
}

// Запуск программы 
int number1 = ReadData ("Enter your number m: ");
string result = LineGenRec (1,number1);
PrintResult (result);
