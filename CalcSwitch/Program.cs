using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double total = 0;
            char oper;
            bool ok = true;


            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите действие:");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            
            switch (oper)
            {
                case '+':
                    total = a + b;
                    break;
                case '-':
                    total = a - b;
                    break;
                case '*':
                    total = a * b;
                    break;
                case '/':
                    if (b != 0)      //во избежания деления на ноль
                    {
                        total = a / b;
                        break;
                    }
                    else
                    {
                        goto default;
                    }
                default:
                    ok = false;
                    break;
            }
            if (ok)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Ответ: " + total);
            }
            else
            {
                Console.WriteLine("error");
            }

            Console.ReadLine();
        }
    }
}
