// Задайте двумерный массив. Напишите программу, которая будет находить с наименьшей суммой элементов. 
// Программа считает сумму элементов в каждой строке и выдает номер строки с наименьшей суммой

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

// Метод нахождения строки с наименьшей суммой
int SumMinRow (int[,] array)
{
    int minRowLine = 0;
    int SumRow = SumRowElements(array, 0);
        for (int i = 1; i < array.GetLength(0); i++)
        {
            int bufSumLine = SumRowElements(array, i);
            if (SumRow > bufSumLine)
                {
                SumRow = bufSumLine;
                minRowLine = i;
                }
        }
        return minRowLine;
}

//Метод расчета суммы по строкам
int SumRowElements(int[,] array, int i)
{
    int SumRow = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        SumRow += array[i,j];
    }
  return SumRow;
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
int N =0;
int SumRE = SumRowElements (array2D, N);
int MinSumRow = SumMinRow (array2D);
Console.WriteLine ("Row Min Sum = " +MinSumRow);


