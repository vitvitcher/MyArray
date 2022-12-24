using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray<int> arr = new MyArray<int>(new int[] { 3, 5, 7, 3, 4, 8 });
            arr.ToString();
            arr.Add(1);
            arr.ToString();
            arr.Append(new int[] { 4, 5, 6, 10, 11, 15 });
            arr.ToString();
            arr.Sort();
            arr.ToString();
            arr.Remove(4);
            arr.ToString();
        }
    }
}
