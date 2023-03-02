// Напишите программу, которая задает массив из N элементов и выводит их на экран. Ввести с клавиатуры длину массива и диапазон значений элементов 

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.Write (message);
    // Считываем число и парсим его 
    return int.Parse (Console.ReadLine()??"0");
}

void Print1DArray (int [] array)
{
    Console.Write ("[");
        for (int i = 0; i <array.Length-1; i++)
        {
            Console.Write (array[i] +", ");
        }
    Console.WriteLine (array[array.Length-1]+"]");
}

// Метод генерации массива 
int [] Gen1DArray (int Length, int min, int max)
{
    Random rnd = new Random();
    int [] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min,max+1);
    }
    return array;
}

int Length = ReadData ("Enter Lenght massiv: ");
int min = ReadData ("Enter min massiv: ");
int max = ReadData ("Enter max massiv: ");


Print1DArray (Gen1DArray(Length,min,max));

// Время, затраченное на метод 
Console.Write ("Elapsed time = ");
DateTime d1 = DateTime.Now;
Console.WriteLine (DateTime.Now - d1);



