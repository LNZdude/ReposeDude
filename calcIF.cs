using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                double firstvalue, secondvalue;
                string action;
                try
                {
                    Console.WriteLine("Введите число 1");
                    firstvalue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число 2");
                    secondvalue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите корректные данные");
                    Console.ReadLine();
                    continue;
                }
                

                Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
                action = Console.ReadLine();

                if (action == "+")
                {
                    Console.WriteLine(firstvalue + secondvalue);
                }
                else if (action == "-")
                {
                    Console.WriteLine(firstvalue - secondvalue);
                }
                else if (action == "*")
                {
                    Console.WriteLine(firstvalue * secondvalue);
                }
                else if (action == "/")
                {
                    if (secondvalue == 0)
                        Console.WriteLine(0);
                    else
                    {
                        Console.WriteLine(firstvalue / secondvalue);
                    }

                }
                else
                {
                    Console.WriteLine("Ошибка! неизвестное действие!");
                    Console.WriteLine("Ошибка! неизвестное действие!");
                }


                Console.ReadLine();
            }
            
        }
    }
}
