using System;

namespace lesson4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] PLF = new string[4];
            int i = 0;
            for ( i = 0; i < 4; i++)
            {
                Console.WriteLine("Для окончания ввода ФИО наберите exit.");
                Console.WriteLine($"Вы еще можете ввести {4-i} ФИО");
                Console.WriteLine("Введите Фамилию:");
                string firstName = Console.ReadLine();
                if (firstName == "exit") break;
                Console.WriteLine("Введите Имя:");
                string lastName = Console.ReadLine();
                if (lastName == "exit") break;
                Console.WriteLine("Введите Отчество:");
                string patronymic = Console.ReadLine();
                if (patronymic == "exit") break;
                PLF[i] = GetFullName(firstName, lastName, patronymic);
                Console.Clear();
            }
            int j = i;
            for (i = 0; i < j; i++)
            {
                Console.WriteLine(PLF[i]);
            }
        }
        static string GetFullName(string firstName, string lastName, string patronymic) //метод(ф-ция) соединения ФИО в строку
        {
            return firstName + " " + lastName + " " + patronymic;
        }
    }
}
