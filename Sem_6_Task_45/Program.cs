// Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементого копирования


// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.Write (message);
    // Считываем число и парсим его 
    return int.Parse (Console.ReadLine()??"0");
}

// Метод печати массива первоначального
void Print1DArray (int [] array)
{
    Console.Write ("Generated massiv [");
        for (int i = 0; i <array.Length-1; i++)
        {
            Console.Write (array[i] +", ");
        }
    Console.WriteLine (array[array.Length-1]+" ]");
}
// Метод печати массива скопированного
void PrintCopyArray (int [] array)
{
    Console.Write ("Copy massiv [");
        for (int i = 0; i <array.Length-1; i++)
        {
            Console.Write (array[i] +", ");
        }
    Console.WriteLine (array[array.Length-1]+" ]");
}
// Метод генерации массива с методом исключения ошибки min/max
int [] Gen1DArray (int Length, int min, int max)
{
    if (min>max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    int [] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min,max+1);
    }
    return array;
}

// Метод поэлементого копирования
int [] CopyArrayStandart (int [] array)
{
    int [] outArray = new int[array.Length];
    array.CopyTo (array,0);
   return outArray;
}

// Обращение к методу ввода
int Length = ReadData ("Enter Lenght massiv: ");
int min = ReadData ("Enter min massiv: ");
int max = ReadData ("Enter max massiv: ");

// Вывод сгенерироанного массива
int []arr = Gen1DArray(Length,min,max);
Print1DArray (arr);
int [] arrCopy = CopyArrayStandart (arr);
PrintCopyArray (arr);
