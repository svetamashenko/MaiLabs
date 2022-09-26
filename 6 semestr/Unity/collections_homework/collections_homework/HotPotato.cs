using System;
using System.Collections;
using System.Collections.Generic;

namespace collections_homework
{
    class HotPotato
    {
        private IQueue<string> queue;
        public HotPotato(IQueue<string> queue)
        {
            this.queue = queue;
        }
        public string Play(int n)
        {
            for (int i = 0; i < n; i++)
                queue.Enqueue(queue.Dequeue());
            return queue.Dequeue();
        }
        public bool GameOver { get { return queue.Count == 1; } }
        public string Winner
        {
            get
            {
                if (GameOver)
                    return queue.Dequeue();
                else
                    return null;
            }
        }
    }
}
