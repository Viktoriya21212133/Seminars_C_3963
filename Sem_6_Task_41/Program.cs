// Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 он ввел

Console.Write("Enter your numbers: ");
// Приглашение на ввод чисел
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

//Метод проверки  
int PositiveNumbers (int [] numbers)
{
    int count = 0;
    for (int i = 0; i<numbers.Length; i++)
    {
        if (numbers[i]>0)
        {
            count++;
        }
    }
    return count;
}

int count = PositiveNumbers (numbers);
Console.WriteLine ("number of positive numbers = "+ count);
