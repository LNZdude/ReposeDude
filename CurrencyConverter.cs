using System;

/*

КОНВЕРТЕР ВАЛЮТ В ГРИВНЕ  

*/
namespace LessonsSC
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                string EnterCurrency;           
                string CourseCurrvalue0;
                string CourseCurrvalue1;
                string CourseCurrvalue2;
                string AdminMenu; 
                double secondvalue;           
                double thirdvalue;
                double result;

                try
                {

                    Console.WriteLine(" Введите курс Валюты евро: ");

                    EnterCurrency = Console.ReadLine();

                    secondvalue = Convert.ToDouble(EnterCurrency);
                    
                    Console.WriteLine(" Введите кол-во Евро которое хотите обменять: ");

                    CourseCurrvalue0 = Console.ReadLine();

                    thirdvalue = Convert.ToDouble(CourseCurrvalue0);
                    result = thirdvalue * secondvalue;
                    Console.WriteLine(" Кол-во в Гривне: " + result);
                }
                
                catch (Exception)
                {
                    Console.WriteLine("Введите корректные данные!");
                    continue;
                }

                Console.ReadLine();

            }
           


        }
    }
}
