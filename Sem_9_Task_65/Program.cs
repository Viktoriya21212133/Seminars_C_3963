// Задайте значения m и n. Напишите программу, которая найдет все натуральные элементы в промежутке от m до n

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
string RecMN (int m, int n)
{
    string res = string.Empty;
        if (m>=n)
        {
        res = n.ToString();
        }
        else
        {
        res = res+m+" "+RecMN(m+1,n);
        }
return res;
}

// Запуск программы 
int number1 = ReadData ("Enter your number m: ");
int number2 = ReadData ("Enter your number n: ");
string result = number1<number2?RecMN(number1,number2):RecMN(number2,number1);
PrintResult (result);

