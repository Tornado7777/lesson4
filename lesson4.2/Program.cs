/*2.	Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, 
 * и возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести 
 * результат на экран.
 */
using System;

namespace lesson4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите набор целых чисел разделяя числа пробелом, для получения их суммы:");
            string NumberText = Console.ReadLine();
            string CurrentNum = "0";
            int sum = 0;
            for (int i=0;i<NumberText.Length;i++)
            {
                while (i < NumberText.Length)
                {
                    if (NumberText[i].ToString() == " ")  break;
                    CurrentNum = CurrentNum + NumberText[i];
                    i++;
                }
                sum = sum + Convert.ToInt32(CurrentNum);
                CurrentNum = "0";
            }
            Console.WriteLine(sum);
        }
    }
}
