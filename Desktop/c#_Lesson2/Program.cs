// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Напишите программу, которая выводит случайное число из             семинар 2
//  отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int num= new Random().Next(10,100);

// Console.WriteLine(num);

// int num1= num/10;
// int num2 = num % 10;

// if(num1>num2)
// {
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.WriteLine(num2);
// }


// Напишите программу, которая выводит случайное
//  трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46   456 /10 = 4    456 % 10 =6     4*10 +6= 46
// 782 -> 72
// 918 -> 98

// int num= new Random().Next(100,1000);

// Console.WriteLine(num);

//  int num1= num/100;       
// int num2 = num % 10;

// int result = num1*10+num2;
// Console.WriteLine(result);

// Напишите программу, которая будет принимать на
//  вход два числа и выводить, является ли первое
//   число кратным второму. Если число 1 не кратно числу 2,
//    то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.WriteLine("Введите число");
// int num1= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2= Convert.ToInt32(Console.ReadLine());

// if(num1>=num2)

// {
//     if(num1 %num2==0)
//     {
//         Console.WriteLine("кратно");
//     }
//     else
//     {
//         Console.WriteLine($"не кратно, остаток {num1 %num2} ");
//     }
// }

// Напишите программу, которая принимает на вход число
//  и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.WriteLine("Введите число");
// int num1= Convert.ToInt32(Console.ReadLine());

// if(num1 % 7 ==0 && num1 % 23 ==0)    // && - и то и то   || - или
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Напишите программу, которая принимает на вход два 
// числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите число");
int num1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num2= Convert.ToInt32(Console.ReadLine());

if(num1 == num2*num2 || num2 == num1*num1)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}



//  Домашняя работа Семинар 2


// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1у.

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

//  if( num > 99)
//  {
//    Console.WriteLine((num/10)%10); 
//  }


//   Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
 
 
//  if(num>=100)
//  {
//     while (num>=1000)
//     {
//      num=num/10;   
//     }
    
//      num=num%10;

//   Console.WriteLine(num); 
//   }
//   else
//   {
//   Console.WriteLine("Третьей цифры нет"); 
//   }

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число");
//  int dayNumber = Convert.ToInt32(Console.ReadLine());

//  if(dayNumber == 6 || dayNumber == 7)
 
// Console.WriteLine("(Это выходной) -> да");

// else if(dayNumber < 1 || dayNumber > 7)

// Console.WriteLine("Это не день недели");

// else
// Console.WriteLine("(Это не выходной) -> нет");



    

