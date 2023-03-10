// Задайте двумерный массив, найдите элементы, у которых оба индекса четные и замените эти элементы на их квадраты

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

//Подсчет по четным индексам
int [,] Update2DArray (int [,] array)
{
    for (int i = 0; i< array.GetLength(0); i=i+2)
    {
        for (int j = 0; j< array.GetLength(1); j=j+2)
            array[i,j] *= array[i,j];
    }
    return array;
}

// Вводим данные 
int countRow = ReadData ("Enter the number of Row: ");
int countColumn = ReadData ("Enter the number of columns: ");
int min = ReadData ("Enter min massiv: ");
int max = ReadData ("Enter max massiv: ");

int [,] array2D = Gen2DArray (countRow, countColumn, min, max);
Print2DArray (array2D);
Console.WriteLine ();
int [,] arrayUpdate = Update2DArray (array2D);
Print2DArray (arrayUpdate);