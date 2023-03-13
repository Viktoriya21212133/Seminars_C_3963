// Напишите программу, которая принимает на вход число и возвращает сумму цифр этого числа

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
int RecSumDig (int num)
{
    if (num == 0)
    {
        return 0;
    }
    else 
    {
        return num%10+RecSumDig(num/10);
    }
    
}
// Вызов метода
int number = ReadData ("Enter your number m: ");
int result = RecSumDig (number);
PrintResult (result);
