// Decompiled with JetBrains decompiler
// Type: System.Collections.Generic.Queue`1
// Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: 29A6C194-5F57-4474-95FC-AD42118554C7
// Assembly location: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\System.dll

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Collections.Generic
{
    //[DebuggerTypeProxy(typeof(System_QueueDebugView<>))]
    //[DebuggerDisplay("Count = {Count}")]
    //[ComVisible(false)]
    //[__DynamicallyInvokable]
    //[Serializable]
    public class Queue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
    {
        private T[] _array;
        private int _head;
        private int _tail;
        private int _size;
        private int _version;
        [NonSerialized]
        private object _syncRoot;
        private const int _MinimumGrow = 4;
        private const int _ShrinkThreshold = 32;
        private const int _GrowFactor = 200;
        private const int _DefaultCapacity = 4;
        private static T[] _emptyArray = new T[0];

        [__DynamicallyInvokable]
        public Queue() => this._array = Queue<T>._emptyArray;

        [__DynamicallyInvokable]
        public Queue(int capacity)
        {
            if (capacity < 0)
                ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity, ExceptionResource.ArgumentOutOfRange_NeedNonNegNumRequired);
            this._array = new T[capacity];
            this._head = 0;
            this._tail = 0;
            this._size = 0;
        }

        [__DynamicallyInvokable]
        public Queue(IEnumerable<T> collection)
        {
            if (collection == null)
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
            this._array = new T[4];
            this._size = 0;
            this._version = 0;
            foreach (T obj in collection)
                this.Enqueue(obj);
        }

        [__DynamicallyInvokable]
        public int Count
        {
            [__DynamicallyInvokable]
            get => this._size;
        }

        [__DynamicallyInvokable]
        bool ICollection.IsSynchronized
        {
            [__DynamicallyInvokable]
            get => false;
        }

        [__DynamicallyInvokable]
        object ICollection.SyncRoot
        {
            [__DynamicallyInvokable]
            get
            {
                if (this._syncRoot == null)
                    Interlocked.CompareExchange<object>(ref this._syncRoot, new object(), (object)null);
                return this._syncRoot;
            }
        }

        [__DynamicallyInvokable]
        public void Clear()
        {
            if (this._head < this._tail)
            {
                Array.Clear((Array)this._array, this._head, this._size);
            }
            else
            {
                Array.Clear((Array)this._array, this._head, this._array.Length - this._head);
                Array.Clear((Array)this._array, 0, this._tail);
            }
            this._head = 0;
            this._tail = 0;
            this._size = 0;
            ++this._version;
        }

        [__DynamicallyInvokable]
        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
            if (arrayIndex < 0 || arrayIndex > array.Length)
                ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.arrayIndex, ExceptionResource.ArgumentOutOfRange_Index);
            int length1 = array.Length;
            if (length1 - arrayIndex < this._size)
                ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
            int num = length1 - arrayIndex < this._size ? length1 - arrayIndex : this._size;
            if (num == 0)
                return;
            int length2 = this._array.Length - this._head < num ? this._array.Length - this._head : num;
            Array.Copy((Array)this._array, this._head, (Array)array, arrayIndex, length2);
            int length3 = num - length2;
            if (length3 <= 0)
                return;
            Array.Copy((Array)this._array, 0, (Array)array, arrayIndex + this._array.Length - this._head, length3);
        }

        [__DynamicallyInvokable]
        void ICollection.CopyTo(Array array, int index)
        {
            if (array == null)
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
            if (array.Rank != 1)
                ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
            if (array.GetLowerBound(0) != 0)
                ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
            int length1 = array.Length;
            if (index < 0 || index > length1)
                ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_Index);
            if (length1 - index < this._size)
                ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
            int num = length1 - index < this._size ? length1 - index : this._size;
            if (num == 0)
                return;
            try
            {
                int length2 = this._array.Length - this._head < num ? this._array.Length - this._head : num;
                Array.Copy((Array)this._array, this._head, array, index, length2);
                int length3 = num - length2;
                if (length3 <= 0)
                    return;
                Array.Copy((Array)this._array, 0, array, index + this._array.Length - this._head, length3);
            }
            catch (ArrayTypeMismatchException ex)
            {
                ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
            }
        }

        [__DynamicallyInvokable]
        public void Enqueue(T item)
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

        [__DynamicallyInvokable]
        public Queue<T>.Enumerator GetEnumerator() => new Queue<T>.Enumerator(this);

        [__DynamicallyInvokable]
        IEnumerator<T> IEnumerable<T>.GetEnumerator() => (IEnumerator<T>)new Queue<T>.Enumerator(this);

        [__DynamicallyInvokable]
        IEnumerator IEnumerable.GetEnumerator() => (IEnumerator)new Queue<T>.Enumerator(this);

        [__DynamicallyInvokable]
        public T Dequeue()
        {
            if (this._size == 0)
                ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EmptyQueue);
            T obj = this._array[this._head];
            this._array[this._head] = default(T);
            this._head = (this._head + 1) % this._array.Length;
            --this._size;
            ++this._version;
            return obj;
        }

        [__DynamicallyInvokable]
        public T Peek()
        {
            if (this._size == 0)
                ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EmptyQueue);
            return this._array[this._head];
        }

        [__DynamicallyInvokable]
        public bool Contains(T item)
        {
            int index = this._head;
            int size = this._size;
            EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
            while (size-- > 0)
            {
                if ((object)item == null)
                {
                    if ((object)this._array[index] == null)
                        return true;
                }
                else if ((object)this._array[index] != null && equalityComparer.Equals(this._array[index], item))
                    return true;
                index = (index + 1) % this._array.Length;
            }
            return false;
        }

        internal T GetElement(int i) => this._array[(this._head + i) % this._array.Length];

        [__DynamicallyInvokable]
        public T[] ToArray()
        {
            T[] objArray = new T[this._size];
            if (this._size == 0)
                return objArray;
            if (this._head < this._tail)
            {
                Array.Copy((Array)this._array, this._head, (Array)objArray, 0, this._size);
            }
            else
            {
                Array.Copy((Array)this._array, this._head, (Array)objArray, 0, this._array.Length - this._head);
                Array.Copy((Array)this._array, 0, (Array)objArray, this._array.Length - this._head, this._tail);
            }
            return objArray;
        }

        private void SetCapacity(int capacity)
        {
            T[] objArray = new T[capacity];
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

        [__DynamicallyInvokable]
        public void TrimExcess()
        {
            if (this._size >= (int)((double)this._array.Length * 0.9))
                return;
            this.SetCapacity(this._size);
        }

        [__DynamicallyInvokable]
        [Serializable]
        public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
        {
            private Queue<T> _q;
            private int _index;
            private int _version;
            private T _currentElement;

            internal Enumerator(Queue<T> q)
            {
                this._q = q;
                this._version = this._q._version;
                this._index = -1;
                this._currentElement = default(T);
            }

            [__DynamicallyInvokable]
            public void Dispose()
            {
                this._index = -2;
                this._currentElement = default(T);
            }

            [__DynamicallyInvokable]
            public bool MoveNext()
            {
                if (this._version != this._q._version)
                    ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
                if (this._index == -2)
                    return false;
                ++this._index;
                if (this._index == this._q._size)
                {
                    this._index = -2;
                    this._currentElement = default(T);
                    return false;
                }
                this._currentElement = this._q.GetElement(this._index);
                return true;
            }

            [__DynamicallyInvokable]
            public T Current
            {
                [__DynamicallyInvokable]
                get
                {
                    if (this._index < 0)
                    {
                        if (this._index == -1)
                            ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumNotStarted);
                        else
                            ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumEnded);
                    }
                    return this._currentElement;
                }
            }

            [__DynamicallyInvokable]
            object IEnumerator.Current
            {
                [__DynamicallyInvokable]
                get
                {
                    if (this._index < 0)
                    {
                        if (this._index == -1)
                            ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumNotStarted);
                        else
                            ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumEnded);
                    }
                    return (object)this._currentElement;
                }
            }

            [__DynamicallyInvokable]
            void IEnumerator.Reset()
            {
                if (this._version != this._q._version)
                    ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
                this._index = -1;
                this._currentElement = default(T);
            }
        }
    }
}
