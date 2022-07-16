
void Zadacha13()
{
    

     // Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        int  digit10 = number/10;
        int digit100 = number/10%10;
        if(number> 100 && 1000 > number)
        {  
            Console.WriteLine ( "3 цифра существует:" + number%10);
        }
        else if(number> 999 && 9999>number)
        {  
             Console.WriteLine ( "3 цифра существует:" + digit100);
        }
        else Console.WriteLine ( "3 цифрва не уществует! или вы привысели допустимые значения");
             
       
}

void Zadacha14()
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > 7 || 1 > number)
    {
        Console.WriteLine ( "ошибка");
    }

    else if (number == 6 || number == 7)
    {
        Console.WriteLine ( "Выходной!");
    }

    else Console.WriteLine ( "рабочий день");
}

//Zadacha13();
Zadacha14();
