// Задайте значение N и напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.Write (message);
    // Считываем число и парсим его 
    return int.Parse (Console.ReadLine()??"0");
}

// Метод генерации рекурсии
void LineGenRec (int num)
{
    Console.Write (num + " ");
    if (num == 1)
    {

    }
    else
    {
        LineGenRec (num-1);
    }
} 

// Запуск программы 
int number = ReadData ("Enter your number: ");
LineGenRec (number);