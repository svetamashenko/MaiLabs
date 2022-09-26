using System;
using System.Collections.Generic;
using System.IO;

namespace delegates_homework
{
            
    class Program
    {
        public static StreamWriter sw = new StreamWriter("D:\\Рабочий стол\\Архив\\3 курс\\6 семестр\\Delegate.txt");
        static void Main(string[] args)
        {
            Console.WriteLine("Жизнь в городе N за последние 15 лет");
            sw.WriteLine("Жизнь в городе N за последние 15 лет");
            Console.WriteLine("************************************************************************************************************************");
            sw.WriteLine("************************************************************************************************************************");
            LifeInTown N = new LifeInTown();
            Homo p1 = new Homo("Мария", "Годунова", 1983, 'f');
            Homo p2 = new Homo("Ольга", "Ростова", 1987, 'f');
            Homo p3 = new Homo("Кристина", "Вольная", 1982, 'f');
            Homo p4 = new Homo("Александра", "Димитрова", 1985, 'f');
            Homo p5 = new Homo("Татьяна", "Смирнова", 1996, 'f');
            Homo p6 = new Homo("Марина", "Лихачёва", 1991, 'f');
            Homo p7 = new Homo("Дарья", "Кольская", 1985, 'f');
            Homo p8 = new Homo("Владислава", "Миронова", 1992, 'f');
            Homo p9 = new Homo("Екатерина", "Никольская", 1993, 'f');
            Homo p10 = new Homo("Виктория", "Нечаева", 1975, 'f');
            Homo p11 = new Homo("Яна", "Григорьева", 1984, 'f');
            Homo p12 = new Homo("Полина", "Леонтьева", 1986, 'f');
            Homo p13 = new Homo("Елизавета", "Гладкова", 1994, 'f');
            Homo p14 = new Homo("Василиса", "Максимова", 1988, 'f');
            Homo p15 = new Homo("Мария", "Кравцова", 1972, 'f');
            Homo p16 = new Homo("Николай", "Лебедев", 1973, 'm');
            Homo p17 = new Homo("Антон", "Дмитриев", 1984, 'm');
            Homo p18 = new Homo("Максим", "Кузнецов", 1985, 'm');
            Homo p19 = new Homo("Артём", "Павлов", 1986, 'm');
            Homo p20 = new Homo("Владимир", "Иванов", 1987, 'm');
            Homo p21 = new Homo("Андрей", "Осипов", 1989, 'm');
            Homo p22 = new Homo("Илья", "Соловьёв", 1990, 'm');
            Homo p23 = new Homo("Иван", "Савельев", 1991, 'm');
            Homo p24 = new Homo("Владислав", "Борисов", 1996, 'm');
            Homo p25 = new Homo("Александр", "Тихонов", 1993, 'm');
            Homo p26 = new Homo("Пётр", "Денисов", 1994, 'm');
            Homo p27 = new Homo("Максим", "Герасимов", 1995, 'm');
            Homo p28 = new Homo("Кирилл", "Гаврилов", 1992, 'm');
            Homo p29 = new Homo("Михаил", "Лазарев", 1988, 'm');
            Homo p30 = new Homo("Сергей", "Яковлев", 1978, 'm');

            N.AddTownspeople(p1);
            N.AddTownspeople(p2);
            N.AddTownspeople(p3);
            N.AddTownspeople(p4);
            N.AddTownspeople(p5);
            N.AddTownspeople(p6);
            N.AddTownspeople(p7);
            N.AddTownspeople(p8);
            N.AddTownspeople(p9);
            N.AddTownspeople(p10);
            N.AddTownspeople(p11);
            N.AddTownspeople(p12);
            N.AddTownspeople(p13);
            N.AddTownspeople(p14);
            N.AddTownspeople(p15);
            N.AddTownspeople(p16);
            N.AddTownspeople(p17);
            N.AddTownspeople(p18);
            N.AddTownspeople(p19);
            N.AddTownspeople(p20);
            N.AddTownspeople(p21);
            N.AddTownspeople(p22);
            N.AddTownspeople(p23);
            N.AddTownspeople(p24);
            N.AddTownspeople(p25);
            N.AddTownspeople(p26);
            N.AddTownspeople(p27);
            N.AddTownspeople(p28);
            N.AddTownspeople(p29);
            N.AddTownspeople(p30);

            for (int i = 0; i < 15; i++)
            {
                N.CurrentYear = 2000 + i;
                N.TownEvent += N_TownEvent;
                N.OnTownEvent(N.CurrentYear);
                N.Life(N.CurrentYear);
                N.TownEvent -= N_TownEvent;
            }

        }
        private static void N_TownEvent(int a)
        {
            Console.WriteLine("Прошёл " + a + " год.\n************************************************************************************************************************");
            sw.WriteLine("Прошёл " + a + " год.\n************************************************************************************************************************");
        }
    }
}
