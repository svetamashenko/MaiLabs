using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace links_homework
{
    class ClientMonth
    {
        public int ID;
        public int Month;
        public int HoursPerMonth;
        public ClientMonth(int id, int month, int hours)
        {
            ID = id;
            Month = month;
            HoursPerMonth = hours;
        }
        public override string ToString()
        {
            return "Клиент " + ID + " провёл в фитнес-клубе " + HoursPerMonth + " часов в " + StringMonth(Month) + ".";
        }
        public static IEnumerable<ClientMonth> GetEnumerator()
        {
            for (int i = 1; i < 151; i++)
                for (int j = 1; j < 13; j++)
                {
                    Random rand = new Random();
                    int hours = rand.Next(-25, 35);
                    yield return new ClientMonth(i, j, Math.Abs(hours));
                }
        }
        public string StringMonth(int m)
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
    }
}
