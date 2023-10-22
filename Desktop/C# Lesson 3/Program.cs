// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!"

//  Напишите программу, которая по заданному 
// номеру четверти, показывает диапазон возможных
//  координат точек в этой четверти (x и y).

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// switch (num)
// {
//     case 1:
//     {
//         Console.WriteLine("x>0  y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("x<0  y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("x<0  y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("x>0  y<0");
//         break;
//     }
//     default:
//     {
//         Console.WriteLine("Нет такой четверти");
//         break;
//     }
// }


// / Напишите программу, которая принимает на вход
// //  координаты двух точек и находит расстояние между
//   ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите число");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double s= Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));

// Console.WriteLine(s);


//  Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// 1 способ

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// for(int i =1; i<=num; i++)
// {
//     Console.WriteLine(Math.Pow(i,2));
// }



// 2 способ

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// for(double i = 1; i<=num; i++)
// {
//     double  result = Math.Pow(i,2);

//     Console.Write(result+ " ");
// }

// 3 способ

// int i = 1;

// while(i<=num)
// {
//     Console.Write(Math.Pow(i,2)+ " ");
//     i++;
// }


// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное
//  число number и проверяет, является ли оно палиндромом.



Console.WriteLine ("Введите число ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number [1] == number[3])
    {
        Console.WriteLine(number + "true");
    }

    else
    {
        Console.WriteLine( number + "false");
    }
}
else 
{
    Console.WriteLine (number + " (Это число не 5-и значное)");

    System.Console.WriteLine("false"); 

}






// Внутри класса Answer напишите метод ShowCube, который принимает на вход 
// число (N) и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// for(int i =1; i<=num; i++)
// {
//     Console.WriteLine(Math.Pow(i,3));
// }

