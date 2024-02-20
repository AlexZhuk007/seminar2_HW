//1. Напишите программу, которая принимает
//на вход число и проверяет, кратно ли оно
//одновременно 7 и 23

//int num = 322;
//if (num % 7 == 0 && num % 23 == 0)
//{
//    Console.Write("да");
//}

//else
//    Console.Write("нет");


//2. Напишите программу, которая принимает
//на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
//0 и выдаёт номер координатной четверти плоскости,
//в которой находится эта точка.


//int x = -1;
//int y = 2;

//if (x>0 && y>0)
//{
//    Console.Write ("1 четверть");
//}
//else if (x<0 && y<0)
//{
//  Console.Write ("3 четверть");  
//}

//else if (x>0 && y<0)
//{
//  Console.Write ("2 четверть");  
//}
//else
//{
//    Console.Write ("4 четверть");
//}


//3.Напишите программу, которая принимает
//на вход целое число из отрезка [10, 99] и показывает
//наибольшую цифру числа.

//int num = 88;

//int first = num / 10;
//int second = num % 10;

//if (num < 10 ^ num > 99)
//{
//    Console.Write("Значение за переделами диапазона");
//}

//else if (first == second)
//{
//    Console.Write("равны");
//}

//else if (first > second)
//{
//    Console.Write(first);
//}
//else
//{
//    Console.Write(second);
//}


//4. Напишите программу, которая на вход
//принимает натуральное число N, а на выходе
//показывает его цифры через запятую.

using System.Runtime.CompilerServices;

int num = 1234;
int num1 = num; 
int raz = 0;
int result = 0;

while (num > 0)
{
    num = num / 10;
    raz++;   
}
//Console.Write(raz);


while (num1>0)
{
    result = num1%10;
    num1=num1/10;
    if (num1>0)
    {
      Console.Write(result + ", ");  
    }
    else{
    Console.Write(result);
}}

return result;
