using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _List
{
    public class _List<T> : IEnumerable<T>
    {
        private int Capacity { get; set; }
        public int Count { get => curelem; }
        private int curelem;
        T[] arr = null;
        public T this[int index]
        {
            get
            {
                if (index < 0 && index > Count)
                    throw new IndexOutOfRangeException($"Cannot store more than {index} objects");

                return arr[index];
            }
            set
            {
                if (index < 0 || index > Count)
                    throw new IndexOutOfRangeException($"Cannot store more than {index} objects");

                arr[index] = value;
            }
        }
        public _List()
        {
            Capacity = 4;
            arr = new T[Capacity];
        }
        public _List(int capacity)
        {
            Capacity = capacity;
            arr = new T[Capacity];
        }

        // FUNCTIONS

        //Add function
        public void Add(T value)
        {
            if (Count != arr.Length)
            {

                arr[curelem] = value;
                curelem++;
            }
            else
            {
                T[] newArr = new T[Capacity * 2];
                Capacity = Capacity * 2;
                for (int i = 0; i < arr.Length; i++)
                {
                    newArr[i] = arr[i];
                }
                arr = newArr;
                arr[curelem] = value;
                curelem++;
            }

        }

        //GetElementbyIndex function
        public T GetElementbyIndex(int i)
        {
            return arr[i];
        }

        public override string ToString()
        {
            return $"Count= {Count.ToString()}";
        }

        public IEnumerator<T> GetEnumerator()
        {
            var counter = Count;
            while (counter != 0)
            {
                yield return arr[Count - counter];
                counter--;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}