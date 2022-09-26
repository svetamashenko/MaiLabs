using System;
using System.Collections.Generic;
using System.Text;

namespace delegates_homework
{

    public class HomoEventArgs : EventArgs
    {
        public enum Args { Adulty, Marriage };
    }
    public class Homo
    {
        public string FirstName;
        public string SecondName;
        public int YearOfBirth;
        public char Sex;
        public Homo Spouse = null;

        public delegate void HomoEventHandler(Homo p, HomoEventArgs.Args e);

        public event HomoEventHandler HomoEvent;

        public void OnHomoEvent(Homo p, HomoEventArgs.Args a)
        {
            if (HomoEvent != null)
            {
                HomoEvent(this, new HomoEventArgs.Args());
            }
        }

        public Homo(string firstname, string secondname, int year, char sex)
        {
            FirstName = firstname;
            SecondName = secondname;
            YearOfBirth = year;
            Sex = sex;
        }
        public void Marry(Homo partner)
        {
            if ((this.Spouse == null) && (partner.Spouse == null))
            {
                this.Spouse = partner;
                partner.Spouse = this;
                this.OnHomoEvent(this, HomoEventArgs.Args.Marriage);
            }
        }
        public void ComingOfAge(int year)
        {
            if (year - this.YearOfBirth == 18)
            {
                this.HomoEvent += new Homo.HomoEventHandler(LifeInTown.Homo_HomoEvent);
                this.OnHomoEvent(this, HomoEventArgs.Args.Adulty);
                this.HomoEvent -= new Homo.HomoEventHandler(LifeInTown.Homo_HomoEvent);
            }
        }
    }
    public class LifeInTown
    {
        public int CurrentYear;
        public List<Homo> Townspeople = new List<Homo>();
        public int population()
        {
            return Townspeople.Count;
        }

        public LifeInTown this[int year]
        {
            get
            {
                CurrentYear = year;
                return this;
            }
            set
            {
                this.CurrentYear = year;
            }
        }
        public void AddTownspeople(Homo person) => this.Townspeople.Add(person);
        public List<Homo> Bachelor()
        {
            List<Homo> Bachelors = new List<Homo>();
            foreach (Homo people in Townspeople)
                if (people.Spouse == null)
                    Bachelors.Add(people);
            return Bachelors;
        }
        public List<Homo> Adult()
        {
            List<Homo> Adults = new List<Homo>();
            foreach (Homo people in Townspeople)
                if ((CurrentYear - people.YearOfBirth) >= 18)
                    Adults.Add(people);
            return Adults;
        }
        public delegate void TownEventHandler(int a);

        public event TownEventHandler TownEvent;

        public void OnTownEvent(int a)
        {
            if (TownEvent != null)
            {
                TownEvent(this.CurrentYear);
            }
        }
        public void Life(int year)
        {
            LifeInTown N = this[year];
            this.Adult();
            this.Bachelor();
            foreach (Homo person in this.Townspeople)
            {
                person.ComingOfAge(year);
            }

            Random rnd = new Random();
            List<Homo> adult = this.Adult();
            List<Homo> male = new List<Homo>();
            List<Homo> female = new List<Homo>();
            foreach (Homo person in this.Bachelor())
                if (adult.Contains(person) && person.Sex == 'm')
                    male.Add(person);
                else if (adult.Contains(person) && person.Sex == 'f')
                    female.Add(person);
            int fin = Math.Min(male.Count, female.Count);

            for (int j = 0; j < fin; j++)
            {
                int x = rnd.Next(0, male.Count - 1);
                int y = rnd.Next(0, female.Count - 1);
                male[x].HomoEvent += new Homo.HomoEventHandler(LifeInTown.Homo_HomoEventM);
                male[x].Marry(female[y]);
                male[x].HomoEvent -= new Homo.HomoEventHandler(LifeInTown.Homo_HomoEventM);
            }

            Console.WriteLine("************************************************************************************************************************");
            Program.sw.WriteLine("************************************************************************************************************************");

        }
        public static void Homo_HomoEvent(Homo p, HomoEventArgs.Args e)
        {
            Console.WriteLine($"{p.FirstName} {p.SecondName} достиг(ла) совершеннолетия.");
            Program.sw.WriteLine($"{p.FirstName} {p.SecondName} достиг(ла) совершеннолетия.");
        }
        public static void Homo_HomoEventM(Homo p, HomoEventArgs.Args e)
        {
            Console.WriteLine($"{p.FirstName} {p.SecondName} {p.YearOfBirth} г.р. и {p.Spouse.FirstName} {p.Spouse.SecondName} {p.Spouse.YearOfBirth} г.р. сочетались законным браком.");
            Program.sw.WriteLine($"{p.FirstName} {p.SecondName} {p.YearOfBirth} г.р. и {p.Spouse.FirstName} {p.Spouse.SecondName} {p.Spouse.YearOfBirth} г.р. сочетались законным браком.");
        }
    }
}
