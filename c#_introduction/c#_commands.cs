// // #pragma warning disable <код предуприждения> - отключение предуприждений в консоле.
// #pragma warning disable IDE0035
// #pragma warning restore IDE0035
// #pragma warning disable CS0162
// #pragma warning restore CS0162


// using System.Runtime.ExceptionServices;

// using System.Xml.XPath;

// Console.Clear();

// // Console.Write($"Введите значение для А");
// // Console.Write(" ");
// // int A = int.Parse(Console.ReadLine()!);
// // Console.Write($"Введите значение для В");
// // Console.Write(" ");
// // int B = int.Parse(Console.ReadLine()!);
// // Console.WriteLine($"summa = {A + B}");

// int a, b;
// bool first, second;
// Console.Write($"Введите первое число: ");
// #pragma warning disable CA1806 // Не игнорируйте результаты метода
// first = int.TryParse(Console.ReadLine(), out a);
// #pragma warning restore CA1806 // Не игнорируйте результаты метода
// Console.Write($"Введите второе число: ");
// #pragma warning disable CA1806 // Не игнорируйте результаты метода
// second = int.TryParse(Console.ReadLine(), out b);
// #pragma warning restore CA1806 // Не игнорируйте результаты метода

// if (first == true && second == true)
// {
//         Console.WriteLine($"{a} + {b} = {a + b}");
//         Console.WriteLine($"{a} - {b} = {a - b}");
//         Console.WriteLine($"{a} * {b} = {a * b}");
//         Console.WriteLine($"{a} / {b} = {(double)a / b}");
// }
// else
// {
//     Console.WriteLine($"Bead");
// }


// if (a > b)
// {
// #pragma warning disable CS0162 // Обнаружен недостижимый код
//     Console.WriteLine($"a > b");
// #pragma warning restore CS0162 // Обнаружен недостижимый код
// }
// else
// {
//     Console.WriteLine($"a < b");
// }






// ---------------------------------------------------------------------------------------------
// Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.


// using System;

// public class Answer
// {


//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {                                       // Введите свое решение ниже
//         if (firstNumber > secondNumber)
//         {
//             Console.WriteLine($"Первое число {firstNumber} больше второго {secondNumber}");
//         }

//         else if (firstNumber < secondNumber)
//         {
//             Console.WriteLine($"Первое число {firstNumber} меньше второго {secondNumber}");
//         }
//         else
//         {
//             Console.WriteLine($"Число {firstNumber} и число {secondNumber} равны");
//         }
//     }


//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2)
//         {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 9;
//             secondNumber = 5;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }






// // ------------------------------------------------------------------------------------------
// // Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number),
// // а на выходе выводит все чётные числа от 1 до number (включительно), после каждого числа должен быть знак пробела


// using System;

// public class Answer {

//   static int FindMax(int a, int b, int c)
//     {
//     if (a >= b && a >= c)
//         {
//             return a;
//         }
//         else if (b >= a && b >= c)
//         {
//             return b;
//         }
//         else
//         {
//             return c;
//         }
//     }

//   // Не удаляйте и не меняйте метод Main! 
//   static public void Main(string[] args) {
//         int a, b, c;

//         if (args.Length >= 3) {
//            a = int.Parse(args[0]);
//            b = int.Parse(args[1]);
//            c = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            a = 10;
//            b = 6;
//            c = 7;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }




// // --------------------------------------------------------------------------------------------
// //  Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит,
// //  является ли число чётным (делится ли оно на два без остатка).

// using System;

// class Answer {
//     static void CheckIfEven(int number)
//     {
//      if(number % 2 == 0)
//      {
//         Console.WriteLine($"четное");
//      }
//      else
//      {
//         Console.WriteLine($"нечетное");
//      }


//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 3;
//         }

//         // Не удаляйте строки ниже
//         CheckIfEven(number);
//     }
// }




// // ----------------------------------------------------------------------------------------------------
// // Внутри класса Answer напишите метод PrintEvenNumbers, 
// // которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно),
// // после каждого числа должен быть знак пробела

// using System;

// public class Answer
// {
//     static void PrintEvenNumbers(int number)
//     {
//         for (int i = 1; i <= number; i++)
//         {
//             if (i % 2 == 0)
//             {
//                 Console.Write(i + " ");
//             }
//         }

//     }


//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int number;

//         if (args.Length >= 1)
//         {
//             number = int.Parse(args[0]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 7;
//         }

//         // Не удаляйте строки ниже
//         PrintEvenNumbers(number);
//     }
// }


// // -----------------------------------------------
// // Напишите программу, которая принимает на вход
// // трёхзначное число и удаляет вторую цифру этого
// // числа.

// Console.WriteLine($"Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = num / 100;
// Console.WriteLine($"{num1}");
// int num2 = num % 10;
// Console.WriteLine($"{num2}");
// if(num > 99 && num < 1000)
// {
// Console.WriteLine($"{num1 * 10 + num2}");
// }
// else
// {
//     Console.WriteLine($"Не корректно введено число");
// // }



// // -------------------------------------------------------
// // Напишите программу, которая принимает на вход трёхзначное
// // число и возводит вторую цифру этого числа в степень, равную
// // третьей цифре


// // //Console.Clear();

// // Console.Write($"Введите трёхзначное число: ");
// // int num = Convert.ToInt32(Console.ReadLine());
// // if (num > 99 && num < 10000)
// // {
// //     int num1 = (num % 100) / 10;
// //     int level = num % 10;
// //     Console.WriteLine($"{num1}");
// //     Console.WriteLine($"{level}");

//     // int result = 1;
//     // while (level >= 1)
//     // {
//     //     result = num1 * result;
//     //     level--;
//     // }
//     //    for (int result = 1; level >= 1; result--)
//     //     {
//     //         result = num1 * result;
//     //         Console.WriteLine($"{result}");
//     //     }
//     // Console.WriteLine($"{result}");

//     // int result = 1;
//     // for (int i = num % 10; i >= 1; i--)
//     // {
//     //     result = num1 * result;
//     //     Console.WriteLine($"{result}");
//     // }

// }


// //---------------------------------------------------------------
// // Задание 3. Работа в сессионных залах
// // Семинар 2. Простые алгоритмы на C#
// // Напишите программу, которая будет принимать на вход два
// // числа и выводить, является ли второе число кратным первому.
// // Если второе число некратно первому, то программа выводит
// // остаток от деления.