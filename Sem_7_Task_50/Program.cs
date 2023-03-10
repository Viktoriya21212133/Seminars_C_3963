// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве и возвращает значение этого элемента или же указывает, что его нет

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

//Метод поиска
int Search2DArray (int [,] array, int element)
{
    int result = 0;
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j< array.GetLength(1); j++)
            if (array[i,j] == element)
            result = array[i,j]; break;
    }
    return result;
}


// Вводим данные 
int countRow = ReadData ("Enter the number of Row: ");
int countColumn = ReadData ("Enter the number of columns: ");
int min = ReadData ("Enter min massiv: ");
int max = ReadData ("Enter max massiv: ");
int element = ReadData ("Enter element massiv: ");

// Вывод сгенерированного массива
int [,] array2D = Gen2DArray (countRow, countColumn, min, max);
Print2DArray (array2D);

// Вывод результата поиска
int res = Search2DArray(array2D, element);
if (res>0)
{
    Console.WriteLine ("Element Search = "+res);
}
else
{
    Console.WriteLine ("Element missing");
}
