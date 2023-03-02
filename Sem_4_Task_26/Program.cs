// Напишите программу, которая принимает на вход число и выдает количество цифр в числе

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
// Метод расчета через десятичный логарифм
int NumberOffDigits (int num)
{
    return (int) (Math.Floor (Math.Log10 (num)))+1;
}

// Объявление переменных для методов
int num = ReadData ("Enter number A: ");
int num1 = NumberOffDigits (num);

// Вызов методов

PrintResult ("Enter your number = "+num1);

