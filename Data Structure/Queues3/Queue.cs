using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues3
{
    public class Queue
    {
        private int[] _array;
        private int _head;
        private int _tail;
        private int _size;
        private int _version;
        public static int[] _emptyArray = new int[0];

        

        public Queue(int capacity)
        {

            if (capacity < 0)
            {
                Console.WriteLine("Capacidade precisa ser definida!");
            }

            this._array = new int[capacity];
            this._head = 0;
            this._tail = 0;
            this._size = 0;
        }

        public Queue(IEnumerable<int> collection)
        {
            if (collection == null)
                Console.WriteLine("sla");
            this._array = new int[4];
            this._size = 0;
            this._version = 0;
            foreach (int obj in collection)
                this.Enqueue(obj);
        }

        public Queue()
        {
            this._array = Queue<int>._emptyArray;
        }

        public void Enqueue(int item)
        {
            if (this._size == this._array.Length)
            {
                int capacity = (int)((long)this._array.Length * 200L / 100L);
                if (capacity < this._array.Length + 4)
                    capacity = this._array.Length + 4;
                this.SetCapacity(capacity);
            }
            this._array[this._tail] = item;
            this._tail = (this._tail + 1) % this._array.Length;
            ++this._size;
            ++this._version;
        }

        public int Dequeue()
        {
            if (this._size == 0)
                return 0;
            int obj = this._array[this._head];
            this._array[this._head] = default(int);
            this._head = (this._head + 1) % this._array.Length;
            --this._size;
            ++this._version;
            return obj;
        }

        private void SetCapacity(int capacity)
        {
            int[] objArray = new int[capacity];
            if (this._size > 0)
            {
                if (this._head < this._tail)
                {
                    Array.Copy((Array)this._array, this._head, (Array)objArray, 0, this._size);
                }
                else
                {
                    Array.Copy((Array)this._array, this._head, (Array)objArray, 0, this._array.Length - this._head);
                    Array.Copy((Array)this._array, 0, (Array)objArray, this._array.Length - this._head, this._tail);
                }
            }
            this._array = objArray;
            this._head = 0;
            this._tail = this._size == capacity ? 0 : this._size;
            ++this._version;
        }


        public void Print()
        {
            foreach (var item in _array)
            {
                Console.WriteLine(item);
            }
        }

    }
}
