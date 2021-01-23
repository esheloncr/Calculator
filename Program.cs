using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, count, restart;
            double result;
            while (true)
            {  
                Console.WriteLine("Укажите количество операндов: ");
                count = int.Parse(Console.ReadLine());
                if (count == 1)
                {
                    Console.WriteLine("Не предусмотрены операции с одним операндом, попробуйте ещё раз.");
                }
                else if (count == 2)
                {
                    Console.WriteLine("Укажите номер операции, где: \n 1.Сложение \n 2.Вычитание \n 3.Умножение \n 4.Деление\n");
                    int operation = int.Parse(Console.ReadLine());
                    switch (operation)
                    {
                        case 1:
                            Console.WriteLine("ВВедите первое число ");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("ВВедите второе число ");
                            b = int.Parse(Console.ReadLine());
                            result = a + b;
                            Console.WriteLine("Результат операции:" + " " + result);
                            break;
                        case 2:
                            Console.WriteLine("ВВедите первое число ");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("ВВедите второе число ");
                            b = int.Parse(Console.ReadLine());
                            if (a < b)
                            {
                                result = b - a;
                            }
                            else
                            {
                                result = a - b;
                            }
                            Console.WriteLine("Результат операции:" + " " + result);
                            break;
                        case 3:
                            Console.WriteLine("ВВедите первое число ");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("ВВедите второе число ");
                            b = int.Parse(Console.ReadLine());
                            result = a * b;
                            Console.WriteLine("Результат операции:" + " " + result);
                            break;
                        case 4:
                            Console.WriteLine("ВВедите первое число ");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("ВВедите второе число ");
                            b = int.Parse(Console.ReadLine());
                            if (a < b)
                            {
                                result = (double)a / (double)b;
                            }
                            else
                            {
                                result = a / b;
                            }
                            Console.WriteLine("Результат операции:" + " " + result);
                            break;
                    }
                }
                else if (count == 3)
                {
                    Console.WriteLine("Укажите номер операции, где: \n 1.Сложение \n 2.Вычитание \n 3.Умножение \n 4.Деление\n");
                    int operation = int.Parse(Console.ReadLine());
                    switch (operation)
                    {
                        case 1:
                            Console.WriteLine("ВВедите первое число ");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("ВВедите второе число ");
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите третье число ");
                            c = int.Parse(Console.ReadLine());
                            result = a + b + c;
                            Console.WriteLine("Результат операции:" + " " + result);
                            break;
                        case 2:
                            Console.WriteLine("ВВедите первое число ");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("ВВедите второе число ");
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите третье число ");
                            c = int.Parse(Console.ReadLine());
                            result = a - b - c;
                            Console.WriteLine("Результат операции:" + " " + result);
                            break;
                        case 3:
                            Console.WriteLine("ВВедите первое число ");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("ВВедите второе число ");
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите третье число ");
                            c = int.Parse(Console.ReadLine());
                            result = a * b * c;
                            Console.WriteLine("Результат операции:" + " " + result);
                            break;
                        case 4:
                            Console.WriteLine("ВВедите первое число ");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("ВВедите второе число ");
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите третье число ");
                            c = int.Parse(Console.ReadLine());
                            if (a == 0 | b == 0 | c == 0)
                            {
                                Console.WriteLine("Один из делителей равен нулю, попробуйте ещё раз.");
                            }
                            result = (double)a / b / c;
                            Console.WriteLine("Результат операции:" + " " + result);
                            break;
                    }
                }
                bool allow;
                Console.WriteLine("Продолжить? \n Y \n N \n");
                restart = int.Parse(Console.ReadLine());
                if (restart == 1)
                {
                    allow = true;
                }
                else
                {
                    allow = false;
                    break;
                }
                
            }
        }
    }
}
