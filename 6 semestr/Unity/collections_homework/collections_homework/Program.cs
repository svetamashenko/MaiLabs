using System;
using System.Collections.Generic;

namespace collections_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue<string> queue = new MyQueueQ<string>();
            queue.Enqueue("Гарри");
            queue.Enqueue("Рон");
            queue.Enqueue("Гермиона");
            queue.Enqueue("Драко");
            queue.Enqueue("Фред");
            queue.Enqueue("Джордж");
            queue.Enqueue("Джинни");
            queue.Enqueue("Невилл");
            queue.Enqueue("Полумна");
            Console.WriteLine("Число игроков в начале игры: " + queue.Count + "\n");
            string players = "";
            foreach (var player in queue)
                players += player + ", ";
            Console.WriteLine(players.Remove(players.Length - 2) + "\n");

            Random random = new Random();
            HotPotato Hogwarts = new HotPotato(queue);
            while (Hogwarts.GameOver != true)
                Console.WriteLine("Выбывает игрок " + Hogwarts.Play(random.Next(9)) + ".");
            Console.WriteLine("*****Побеждает игрок " + Hogwarts.Winner + "!*****");
        }
    }
}
