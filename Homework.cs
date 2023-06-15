/*Задача 10: Напишите программу, которая принимает 
на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
/*
int Numbers(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine()!);
    return num;
}

int number3 = Numbers("Введите трехзначное число");
if (number3<100 || number3>=1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, повторите ввод");
}

void Second (int num1)
{
    int result = num1 / 10 % 10;
    Console.WriteLine(result);
}

Second (number3);
*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 

int Numbers(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine()!);
    return num;
}

int number1 = Numbers("Введите число");

int Count3(int number)
{
    int result=-1;
    if(number >=100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;
}
Count3(number1);
int result = Count3(number1);
Console.WriteLine(result);
*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int Numbers(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine()!);
    return num;
}

int number1 = Numbers("Введите число от 1 до 7");

void DayOfWeek (int Day)
{
    if(Day > 5 && Day<7)
    {
        Console.WriteLine("Это выходной");
    }
    else{
        if(Day>=1 && Day<=5)
        {
            Console.WriteLine("Это будний день");
        }
        else
        {
            Console.WriteLine("Такого дня недели нет");
        }
    }
}

DayOfWeek(number1);