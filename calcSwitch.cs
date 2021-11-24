using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstvalue, secondvalue;
            string action;

            Console.WriteLine("Введите число 1");
            firstvalue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            secondvalue = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
            action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Console.WriteLine(firstvalue+secondvalue);
                    break;
                case "-":
                    Console.WriteLine(firstvalue - secondvalue);
                    break;
                case "*":
                    Console.WriteLine(firstvalue * secondvalue);
                    break;
                case "/":

                    if (secondvalue == 0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine(firstvalue / secondvalue);
                    }
                    break;

                default:
                    Console.WriteLine("Ошибка! неизвестное действие!");
                    break;
                    
            
            }
            Console.ReadLine();
        }
    }
}
