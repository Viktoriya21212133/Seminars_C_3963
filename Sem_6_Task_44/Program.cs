// Не используя рекурсию выведите первые N чисел Фиббоначи

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.Write (message);
    // Считываем число и парсим его 
    return int.Parse (Console.ReadLine()??"0");
}

// Метод, который ничего не вернет, но выведет результат
// void PrintData (string message)
// {
//     Console.WriteLine (message);
// }

// Метод Фиббоначи
string FibNum (int num)
{
    string res = "0 1";
    int first = 0;
    int last = 1;
    for (int i=2; i<num; i++)
    {
        res = res+" "+(first+last).ToString();
        (first,last) = (last, first+last);
    }
return res;    
}

int num = ReadData ("Enter number: ");
string result = FibNum (num);
Console.WriteLine (FibNum(num));