using System;
using System.Collections.Generic;

namespace lab9._2_9._3_
{
    class Program
    {
        delegate void Date(int x, int y, int z);
        delegate int Weekend(int w);

        static void Main(string[] args)
        {
            Date date = (x, y, z) => System.Console.WriteLine($"{x}.{y}.{z}");
            Weekend week = (w) => w;

            int number = 30, w = 6;
            date(number, 10, 2020);
            System.Console.WriteLine($"{week(w)} days left to work.");
            string day = "It's Monday. ";
            Student A = new Student("Anton");
            Student B = new Student("Boris");
            Professor AA = new Professor("Anatoly Vladimirovich");
            Journal MAI = new Journal();
            MAI.AddSubscriber(A);
            MAI.AddSubscriber(B);
            MAI.AddSubscriber(AA);
            MAI.NotifySubscribers(day);
            System.Console.WriteLine();

            date(number++, 10, 2020);
            System.Console.WriteLine($"{week(w-1)} days left to work.");
            day = "It's Tuesday. ";
            Student S = new Student("Sergey");
            MAI.RemoveSubscriber(A);
            MAI.AddSubscriber(S);
            MAI.NotifySubscribers(day);
        }
    }
    interface MassMedia
    {
        void AddSubscriber(ISubscriber o);
        void RemoveSubscriber(ISubscriber o);
        void NotifySubscribers(string Day);
    }
    class Journal : MassMedia
    {
        private List<ISubscriber> subscribers;
        public Journal()
        {
            subscribers = new List<ISubscriber>();
        }
        public void AddSubscriber(ISubscriber o)
        {
            subscribers.Add(o);
        }
        public void RemoveSubscriber(ISubscriber o)
        {
            subscribers.Remove(o);
        }
        public void NotifySubscribers(string Day)
        {
            foreach (ISubscriber subscriber in subscribers)
            subscriber.Update(Day);
        }
    }
    interface ISubscriber
    {
        void Update(string Day);
    }
    class Student : ISubscriber
    {
        private string Name = "";
        public Student(string name)
        {
            Name = name;
        }
        public void Update(string Day)
        {
            System.Console.WriteLine($"{Day}News was refreshed. Have a nice day, {Name}.");
        }
    }
    class Professor : ISubscriber
    {
        private string Name = "";
        public Professor(string name)
        {
            Name = name;
        }
        public void Update(string Day)
        {
            System.Console.WriteLine($"{Day}Here the news, pr. {Name}. We wish you a great day!");
        }
    }
}
