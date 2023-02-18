// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что цифры нет
Console.WriteLine("Enter your number");
// Приглашение на считывание числа
string? InputNumber = Console.ReadLine();
//Парсим число
if (InputNumber !=null)
{  
int Num = int.Parse (InputNumber); 
    if (Num <100)
    Console.WriteLine ("Missing third digit"); //Отсутствует третья цифра

        if (Num> 100 && Num<999)
        {
        int resalt1 = Num%10;
        Console.WriteLine (resalt1);
        }
            if (Num> 1000 && Num<9999)
            {
            int resalt2 = (Num%100)/10;
            Console.WriteLine (resalt2);
            }

                if (Num> 10000 && Num<99999)
                {
                int resalt3 = (Num%1000)/100;
                Console.WriteLine (resalt3);
                }

                    if (Num> 100000 && Num<999999)
                    {
                    int resalt4 = (Num%10000)/1000;
                    Console.WriteLine (resalt4);
                    }

                        if (Num> 1000000 && Num<9999999)
                        {
                        int resalt5 = (Num%100000)/10000;
                        Console.WriteLine (resalt5);
                        }

                            if (Num> 10000000 && Num<99999999)
                            {
                            int resalt6 = (Num%1000000)/100000;
                            Console.WriteLine (resalt6);
                            }

                                if (Num> 100000000 && Num<999999999)
                                {
                                int resalt7 = (Num%10000000)/1000000;
                                Console.WriteLine (resalt7);
                                }

                                    if (Num> 1000000000 && Num<9999999999)
                                    {
                                    int resalt8 = (Num%100000000)/10000000;
                                    Console.WriteLine (resalt8);
                                    }

}















