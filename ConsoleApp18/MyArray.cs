using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class MyArray<T>:IEnumerable
    {
        private T[] array = null;
        public MyArray() => array = new T[0];
        public MyArray(T[] array) => this.array = array;

        public void Add(T val)
        {
            T[] temp = array;
            array = new T[array.Length + 1];
            for (int i = 0; i < temp.Length; i++)
            {
                array[i] = temp[i];
            }
            array[array.Length - 1] = val;
        }

        public void Append(T[] arr)
        {
            T[] temp = array;
            array= new T[array.Length + arr.Length];
            int index = 0;
            foreach(T element in temp)
            {
                array[index] = element;
                index++;
            }
            foreach (T element in arr)
            {
                array[index] = element;
                index++;
            }
        }
        public void Remove(T element)
        {
            T[] temp = array;
            int count = 0;
            foreach (T item in temp)
            {
                if (element.Equals(item))
                    count++;
            }
            if (count > 0)
            {
                array = new T[array.Length - count];
                count = 0;
                foreach (T val in temp)
                {
                    if (!element.Equals(val))
                    {
                        array[count] = val;
                        count++;
                    }
                }
            }
            else
            {
                Console.WriteLine("No such value found");
            }
        }

        public void Clear() => array = new T[0];
        public int FindElementIndex(T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (element.Equals(array[i]))
                    return i;
            }
            return -1;
        }
        
        public int[] FindElementIndexes(T element)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (element.Equals(array[i]))
                {
                    count++;
                }
            }
            int[] arr = new int[array.Length-count];
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (element.Equals(array[i]))
                {
                    arr[count] = i;
                    count++;
                }
            }
            return arr;
        }
        public void Sort() => Array.Sort(array);
        public IEnumerator GetEnumerator() { 
            return array.GetEnumerator(); 
        }
        public new void ToString()
        {
            Console.Write("[");
            foreach(T element in array)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine("]");
        }

        public T this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }
    }
}
