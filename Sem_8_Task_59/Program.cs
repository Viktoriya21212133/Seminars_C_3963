// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строчку и столбец на пересечении которого расположен наименьший элемент массива 

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

// Метод поиска минимального числа 
(int x, int y) SearchMin (int [,] array)
{
    int row = 0;
    int collumn = 0;
    int min = int.MaxValue;
        for (int i = 0; i<array.GetLength(0); i++)
        {
            for (int j = 0; j<array.GetLength(1); j++)
            {
                if (array[i,j] < min)
                {
                    min = array[i,j];
                    row = i;
                    collumn = j;
                }
            }
        }
    return (row,collumn);    
}
// Метод удаления
int [,] ConvertedArray (int [,] array, int x, int y)
{
    int [,] uotArray = new int [array.GetLength(0)-1, array.GetLength(1)-1];
    int k=0;
    int m=0;
            for (int i = 0; i<array.GetLength(0); i++)
            {
                m=0;
                for (int j = 0; j<array.GetLength(1); j++)
                {
                    if (i!= x && j!=y)
                    {
                        uotArray [k,m] = array [i,j];
                    }
                    if (j!=y) 
                    m++;
                }
                if (i!= x) 
                k++;
            }
return uotArray;
}

// Вводим данные 
int row = ReadData ("Enter the number of Row: ");
int collumn = ReadData ("Enter the number of columns: ");
int min = ReadData ("Enter min massiv: ");
int max = ReadData ("Enter max massiv: ");
int [,] array2D = Gen2DArray (row, collumn, min, max);
Print2DArray (array2D);
Console.WriteLine ();
(int x, int y) MinElement = SearchMin (array2D);
int [,] out2dArray = ConvertedArray (array2D, MinElement.x, MinElement.y);
Print2DArray (out2dArray);

















