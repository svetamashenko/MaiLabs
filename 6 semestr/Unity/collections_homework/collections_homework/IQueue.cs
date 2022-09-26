using System;
using System.Collections;
using System.Collections.Generic;

namespace collections_homework
{
    class MyQueueQ<T> : IQueue<T>
    {
        Queue<T> queue = new Queue<T>();
        public int Count
        {
            get { return queue.Count; }
        }
        public void Enqueue(T item)
        {
            queue.Enqueue(item);
        }
        public T Dequeue()
        {
            return queue.Dequeue();
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var a in queue)
                yield return a;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class MyQueueS<T> : IQueue<T>
    {
        Stack<T> data = new Stack<T>();
        public int Count { get { return data.Count; } }

        public T Dequeue()
        {
            int count = Count;
            Stack<T> temp = new Stack<T>();
            for (int i = 0; i < count; i++)
            {
                temp.Push(data.Pop());
            }
            T answer = temp.Pop();
            for (int i = 0; i < count - 1; i++)
            {
                data.Push(temp.Pop());
            }
            return answer;
        }

        public void Enqueue(T item)
        {
            data.Push(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var a in data)
                yield return a;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    interface IQueue<T> : IEnumerable<T>
    {
        void Enqueue(T item);
        T Dequeue();
        int Count { get; }
    }

}
