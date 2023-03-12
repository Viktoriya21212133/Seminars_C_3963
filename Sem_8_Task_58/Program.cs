// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.Write (message);
    // Считываем число и парсим его 
    return int.Parse (Console.ReadLine()??"0");
}

// Метод заполнения первого массива
int [,] FirstGen2DArray (int countRow1, int countColumn1, int min1, int max1)
{
    if (min1>max1)
    {
        int buf1 = min1;
        min1 = max1;
        max1 = buf1;
    }
    Random rnd = new Random();
    int [,] firstarray = new int[countRow1,countColumn1];
    for (int i = 0; i < countRow1; i++)
    {
        for (int j = 0; j < countColumn1; j++)
        firstarray[i,j] = rnd.Next(min1,max1+1);
    }
    return firstarray;
}

// Метод заполнения второго массива
int [,] SecondGen2DArray (int countRow2, int countColumn2, int min2, int max2)
{
    if (min2>max2)
    {
        int buf2 = min2;
        min2 = max2;
        max2 = buf2;
    }
    Random rnd = new Random();
    int [,] secondarray = new int[countRow2,countColumn2];
    for (int i = 0; i < countRow2; i++)
    {
        for (int j = 0; j < countColumn2; j++)
        secondarray[i,j] = rnd.Next(min2,max2+1);
    }
    return secondarray;
}


// Метод вывода первого массива
void FirstPrint2DArray (int [,] firstarray)
{
    Console.WriteLine ("First array");
    for (int i = 0; i <firstarray.GetLength(0); i++)
    {
        for (int j = 0; j<firstarray.GetLength(1); j++)
        {
            Console.Write($"{firstarray[i, j]} \t");
        }
    Console.WriteLine ();
    }
}

// Метод вывода второго массива
void SecondPrint2DArray (int [,] secondarray)
{   
    Console.WriteLine ("Second array");
    for (int i = 0; i <secondarray.GetLength(0); i++)
    {
        for (int j = 0; j<secondarray.GetLength(1); j++)
        {
            Console.Write($"{secondarray[i, j]} \t");
        }
    Console.WriteLine ();
    }
}

// Метод вывода результирующего массива
void ResaltPrint2DArray (int [,] resultarray)
{   
    Console.WriteLine ("Result array");
    for (int i = 0; i <resultarray.GetLength(0); i++)
    {
        for (int j = 0; j<resultarray.GetLength(1); j++)
        {
            Console.Write($"{resultarray[i, j]} \t");
        }
    Console.WriteLine ();
    }
}


// Вводим данные для первого массива
int countRow1 = ReadData ("Enter the number of Row for first massiv: ");
int countColumn1 = ReadData ("Enter the number of columns for first massiv: ");
int min1 = ReadData ("Enter min massiv for first massiv: ");
int max1 = ReadData ("Enter max massiv for first massiv: ");
int [,] FirstArrayRes = FirstGen2DArray (countRow1, countColumn1, min1, max1);
FirstPrint2DArray (FirstArrayRes);

// Вводим данные для второго массива
int countRow2 = ReadData ("Enter the number of Row for second massiv: ");
int countColumn2 = ReadData ("Enter the number of columns for second massiv: ");
int min2 = ReadData ("Enter min massiv for second massiv: ");
int max2 = ReadData ("Enter max massiv for second massiv: ");
//Вывод второго сгенерированного массива
int [,] SecondArrayRes = SecondGen2DArray (countRow2, countColumn2, min2, max2);
SecondPrint2DArray (SecondArrayRes);

// Метод перемножения двух массивов
int [,] WorkArray (int[,] FirstArray,int [,] SecondArray)
{
    int [,] ResultArray = new int [FirstArray.GetLength(0),SecondArray.GetLength(1)];
    for (int i = 0; i < ResultArray.GetLength(0); i++)
    {
        for (int j = 0; j < ResultArray.GetLength(1); j++)
        {
            int work =0;
            for (int k = 0; j < FirstArray.GetLength(1); k++)
            {
            work += FirstArray[i,k]*SecondArray[k,j];
            }
            ResultArray[i,j] = work;
        }
    }
    return ResultArray;
}

// Объявление резульирующего массива

int [,] Result = WorkArray (FirstArrayRes,SecondArrayRes);
ResaltPrint2DArray (Result);
