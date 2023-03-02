// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

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
// Метод расчета 
int NumberOffDigits (int num)
{
    int sum=0;
    for (int i=3; i>=0; i--)
{
    sum+=num/(int)Math.Pow(10.0,i);
    num=num%(int)Math.Pow(10.0,i);
}
    return (sum) ;
}

// Объявление переменных для методов
int num = ReadData ("Enter number A: ");
int num1 = NumberOffDigits (num);

// Вызов методов

PrintResult ("Sum number = "+num1);
Console.Write ("Elapsed time = ");

// Время, затраченное на метод 
DateTime d1 = DateTime.Now;
Console.WriteLine (DateTime.Now - d1);
