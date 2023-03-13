// Напишите программу, которая будет принимать два числа А и В и возведет число А в степень В

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.Write (message);
    // Считываем число и парсим его 
    return int.Parse (Console.ReadLine()??"0");
}

// метод вывода результатов
void PrintResult (long message)
{
    Console.WriteLine (message);
}

// функция сумма чисел от M до N
long RecP0ow (int a, int b)
{
    if (b <=1)
        return a;
    else
    {
        return a*RecP0ow(a,b-1);
    }
}

int number1 = ReadData ("Enter your number a: ");
int nunber2 = ReadData ("Enter your number b: ");
long result = RecP0ow (number1,nunber2);
PrintResult (result);
