using System.Numerics;

// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N

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
// Метод расчета факторила, но нужно недопустить переполнение int - long - biginteger
BigInteger FactCalc (int num)
{
    BigInteger result=1;
    for (int i=2; i<=num; i++)
{
    result = result*i;
}
    return (result) ;
}

// Объявление переменных для методов
int num = ReadData ("Enter number A: ");
BigInteger result1 = FactCalc (num);

// Вызов методов

PrintResult ("Enter your number = "+result1);


// Время, затраченное на метод 
Console.Write ("Elapsed time = ");
DateTime d1 = DateTime.Now;
Console.WriteLine (DateTime.Now - d1);

