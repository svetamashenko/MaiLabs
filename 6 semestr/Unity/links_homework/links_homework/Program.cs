using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace links_homework
{        
    class Program
    {
    public static StreamWriter sw = new StreamWriter("D:\\Рабочий стол\\Архив\\3 курс\\6 семестр\\LINQ.txt");
        static void Main(string[] args)
        {
            var DataBase = ClientMonth.GetEnumerator();
            List<ClientMonth> ClientList = DataBase.ToList();

            foreach (ClientMonth a in ClientList)
            {
                Console.WriteLine($"Клиент {a.ID} провёл {a.HoursPerMonth} часов в фитнес-клубе в {StringMonth(a.Month)}.");
            sw.WriteLine($"Клиент {a.ID} провёл {a.HoursPerMonth} часов в фитнес-клубе в {StringMonth(a.Month)}.");
            }
            Console.WriteLine("\n\n");
            sw.WriteLine("\n\n");


            Console.WriteLine("1. Клиент с минимальной продолжительностью занятий: ");
            sw.WriteLine("1. Клиент с минимальной продолжительностью занятий: ");
            ClientMonth MinimalDuration = ClientList.
                Where(c => c.HoursPerMonth == ClientList.Min(c => c.HoursPerMonth)).
                Last();
            Console.WriteLine($"Клиент {MinimalDuration.ID} провёл в {StringMonth(MinimalDuration.Month)} в фитнес-клубе {MinimalDuration.HoursPerMonth} часов.\n\n");
            sw.WriteLine($"Клиент {MinimalDuration.ID} провёл в {StringMonth(MinimalDuration.Month)} в фитнес-клубе {MinimalDuration.HoursPerMonth} часов.\n\n");


            Console.WriteLine("2. Месяц с максимальной посещаемостью: "); 
            sw.WriteLine("2. Месяц с максимальной посещаемостью: ");
            var Visiting = ClientList.
                GroupBy(c => c.Month).
                Select(b => new
                {
                    Month = b.Key,
                    Hours = b.Sum(a => a.HoursPerMonth)
                });
            var MaximalVisiting = Visiting.
                Where(a => a.Hours == Visiting.Max(a => a.Hours)).
                First();
            Console.WriteLine($"В {StringMonth(MaximalVisiting.Month)} в фитнес-клубе клиенты провели {MaximalVisiting.Hours} часов.\n\n");
            sw.WriteLine($"В {StringMonth(MaximalVisiting.Month)} в фитнес-клубе клиенты провели {MaximalVisiting.Hours} часов.\n\n");


            Console.WriteLine("3. Суммарная продолжительность занятий каждого клиента: ");
            sw.WriteLine("3. Суммарная продолжительность занятий каждого клиента: ");
            var ClientVisiting = ClientList.
                GroupBy(a => a.ID).
                Select(c => new
                {
                    ID = c.Key,
                    Hours = c.Sum(h => h.HoursPerMonth)
                }).
                OrderBy(a => a.ID).
                OrderByDescending(a => a.Hours);
            foreach (var person in ClientVisiting)
            {
                Console.WriteLine($"Клиент \t{person.ID}\t за год провёл в фитнес-клубе \t{person.Hours}\t часов.");
                sw.WriteLine($"Клиент \t{person.ID}\t за год провёл в фитнес-клубе \t{person.Hours}\t часов.");
            }
            Console.WriteLine("\n\n"); 
            sw.WriteLine("\n\n");


            Console.WriteLine("4. Число посетителей фитнес-клуба в каждый месяц: "); 
            sw.WriteLine("4. Число посетителей фитнес-клуба в каждый месяц: ");
            var PerMonth = ClientList.
                Where(c => c.HoursPerMonth > 0).
                GroupBy(c => c.Month).
                Select(b => new
                {
                    Month = b.Key,
                    People = b.Count(),
                    Hours = b.Sum(a => a.HoursPerMonth)
                }).
                OrderBy(a => a.Month).
                OrderBy(a => a.People);
            foreach (var month in PerMonth)
            {
                Console.WriteLine($"В \t{StringMonthNice(month.Month)}\t фитнес-клуб посетило \t{month.People}\t клиентов и провело там \t{month.Hours}\t часов.");
                sw.WriteLine($"В \t{StringMonthNice(month.Month)}\t фитнес-клуб посетило \t{month.People}\t клиентов и провело там \t{month.Hours}\t часов.");
            }

        }
        public static string StringMonth(int m)
        {
            switch (m)
            {
                case (1):
                    return "январе";
                case (2):
                    return "феврале";
                case (3):
                    return "марте";
                case (4):
                    return "апреле";
                case (5):
                    return "мае";
                case (6):
                    return "июне";
                case (7):
                    return "июле";
                case (8):
                    return "августе";
                case (9):
                    return "сентябре";
                case (10):
                    return "октябре";
                case (11):
                    return "ноябре";
                case (12):
                    return "декабре";
            }
            return "";
        }
        public static string StringMonthNice(int m)
        {
            switch (m)
            {
                case (1):
                    return "январе  ";
                case (2):
                    return "феврале ";
                case (3):
                    return "марте   ";
                case (4):
                    return "апреле  ";
                case (5):
                    return "мае     ";
                case (6):
                    return "июне    ";
                case (7):
                    return "июле    ";
                case (8):
                    return "августе ";
                case (9):
                    return "сентябре";
                case (10):
                    return "октябре ";
                case (11):
                    return "ноябре  ";
                case (12):
                    return "декабре ";
            }
            return "";
        }
    }
}
