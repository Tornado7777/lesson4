/*3.	Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. 
 * На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. 
 * Написать метод, 
 * принимающий на вход значение из этого перечисления и возвращающий название времени года 
 * (зима, весна, лето, осень). Используя эти методы, ввести с клавиатуры номер месяца и вывести 
 * название времени года. Если введено некорректное число, вывести в консоль текст 
 * «Ошибка: введите число от 1 до 12».*/
using System;

namespace lesson4._3
{
    class Program
    {
        enum Season
        {
            Spring=3,
            Summer=6,
            Autumn=9,
            Winter=12,
            NoSeason =13
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца от 1 до 12:");
            int NumMonth = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(SeasonRus(Season_m(NumMonth)));
        }
        static Season Season_m(int NumMonth0)
            {
            switch (NumMonth0)
                {
                case 1:
                    return Season.Winter;
                case 2:
                    return Season.Winter;
                case 3:
                    return Season.Spring;
                case 4:
                    return Season.Spring;
                case 5:
                    return Season.Spring;
                case 6:
                    return Season.Summer;
                case 7:
                    return Season.Summer;
                case 8:
                    return Season.Summer;
                case 9:
                    return Season.Autumn;
                case 10:
                    return Season.Autumn;
                case 11:
                    return Season.Autumn;
                case 12:
                    return Season.Winter;
                default:
                    
                    return Season.NoSeason;
                }
            
             }
        static string SeasonRus(Season a )
            {
            switch (a)
            {
                case Season.Winter:
                    return "Зима";
                case Season.Spring:
                    return "Весна";
                case Season.Summer:
                    return "Лето";
                case Season.Autumn:
                    return "Осень";
                case Season.NoSeason:
                    return "Ошибка: введите число от 1 до 12.";
                default:

                    return "Ошибка: введите число от 1 до 12.";
            }
            
                
            }
    }
}
