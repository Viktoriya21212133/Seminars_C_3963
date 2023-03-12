// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. Вслучае, если это невозможно, программа даолжна вывести сообщение на экран.

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.Write (message);
    // Считываем число и парсим его 
    return int.Parse (Console.ReadLine()??"0");
}

// Метод заполнения массива
int [,] Gen2DArray (int countRow, int countColumn, int min, int max)
{
    if (min>max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    int [,] array = new int[countRow,countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        array[i,j] = rnd.Next(min,max+1);
    }
    return array;
}

// Метод вывода массива
void Print2DArray (int [,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
    Console.WriteLine ();
    }
}


//Метод перемены мест строчек массива, движениие по столбцам
void TranseArray (int[,] array)
{
    int buf =0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                buf = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = buf;
            }
        }
}

// Вводим данные 
int countRow = ReadData ("Enter the number of Row: ");
int countColumn = ReadData ("Enter the number of columns: ");
int min = ReadData ("Enter min massiv: ");
int max = ReadData ("Enter max massiv: ");

//Вывод сгенерированного массива
int [,] array2D = Gen2DArray (countRow, countColumn, min, max);
Print2DArray (array2D);
Console.WriteLine ();

if (array2D.GetLength(0) == array2D.GetLength(1))
{
    // Обращение к методу транспонирования
    TranseArray (array2D);
    Print2DArray (array2D);
}
else
{
    Console.WriteLine ("Error!");
}


