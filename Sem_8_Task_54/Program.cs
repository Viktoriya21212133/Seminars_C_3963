// Задайте двумерный массив. Напишите программу, которая упорядочет по убыванию элементы каждой строки двумерного массива

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
void ChangeMinMax2DArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int buf = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = buf;
        }
      }
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

// Обращение к методу расчета
ChangeMinMax2DArray (array2D);
Print2DArray (array2D);