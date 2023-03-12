// Задайте двумерный массив, напишите программу, которая поменяет местами первую и последнюю строчки массива

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
void Change2DArray (int [,] array)
{
    int temp = 0;
    for (int j = 0; j< array.GetLength(1); j++)
    {
    temp = array[0,j];
    array[0,j]=array[array.GetLength(0)-1,j];
    array[array.GetLength(0)-1,j] = temp;
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

// Обращение к методу расчета
Change2DArray (array2D);
Print2DArray (array2D);