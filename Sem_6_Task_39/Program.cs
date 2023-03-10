// Напишите программу, которая перевернет одномерный массив. Первый элемент будет на последнем месте и т.д. 

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
    Console.Write ("Generated massiv [");
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

// Метод "переворачивания" массива. Первый метод, классический через буфферную переменную
void SwapArray (int [] array)
{
    int BuffElement = 0;
    for (int i = 0; i<array.Length/2; i++)
    {
        BuffElement = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = BuffElement;
    }
}
// Второй метод, который будет выдавать новый массив
int [] SwapSecondArray (int [] array)
{
    int [] outArray = new int [array.Length];
        for (int i=0; i< array.Length; i++)
            {
                outArray[i]=array[array.Length-1-i];
            }
return outArray;
}

// Обращение к методу ввода
int Length = ReadData ("Enter Lenght massiv: ");
int min = ReadData ("Enter min massiv: ");
int max = ReadData ("Enter max massiv: ");

// Вывод сгенерироанного массива
int []arr = Gen1DArray(Length,min,max);
Print1DArray (arr);

// Вывод перевернутого массива. 1 метод
void PrintSwapArray (int [] SwapArr)
{
    Console.Write ("Swap massiv first method [");
        for (int i = 0; i <SwapArr.Length-1; i++)
        {
            Console.Write (SwapArr[i] +", ");
        }
    Console.WriteLine (SwapArr[SwapArr.Length-1]+"]");
}

// Вывод перевернутого массива. 2 метод
void PrintSwapArraySecond (int [] SwapArrSecond)
{
    Console.Write ("Swap massiv second method [");
        for (int i = 0; i <SwapArrSecond.Length-1; i++)
        {
            Console.Write (SwapArrSecond[i] +", ");
        }
    Console.WriteLine (SwapArrSecond[SwapArrSecond.Length-1]+"]");
}

// Обращение к методу void
SwapArray(arr);
PrintSwapArray (arr);

// Обращение к методу второму
int [] NewArray = SwapSecondArray (arr);
PrintSwapArraySecond (NewArray);

// Время, затраченное на метод 
Console.Write ("Elapsed time = ");
DateTime d1 = DateTime.Now;
Console.WriteLine (DateTime.Now - d1);



