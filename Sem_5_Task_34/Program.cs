// задайте массив, заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество чисел в массиве

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.Write (message);
    // Считываем число и парсим его 
    return int.Parse (Console.ReadLine()??"0");
}

// Метод печати массива 
void Print1DArray (int [] array)
{
    Console.Write ("Generated array [");
        for (int i = 0; i <array.Length-1; i++)
        {
            Console.Write (array[i] +", ");
        }
    Console.WriteLine (array[array.Length-1]+"]");
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

// Метод поиска элемента в массиве

int SumEvenNumber (int [] array)
{
    int res = 0;
   
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 ==0)
            
            res++;
        }
    return (res);
}

// Метод, который ничего не вернет, но выведет результат
void PrintData (string message)
 {
     Console.WriteLine (message);
 }

// Обращение к методу ввода
int Length = ReadData ("Enter Lenght massiv: ");
int min = ReadData ("Enter min massiv: ");
int max = ReadData ("Enter max massiv: ");

// Вывод сгенерированного массива
int []arr = Gen1DArray(Length,min,max);
Print1DArray (arr);

// Вывод результата поиска
int res1 = SumEvenNumber(arr);
PrintData ("Sum index even number = "+res1);

// Время, затраченное на метод 
Console.Write ("Elapsed time = ");
DateTime d1 = DateTime.Now;
Console.WriteLine (DateTime.Now - d1);
