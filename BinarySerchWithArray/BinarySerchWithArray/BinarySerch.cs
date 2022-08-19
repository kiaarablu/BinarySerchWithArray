using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerchWithArray
{
    public class BinarySerch
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        int key = 5;
        int front;
        int rear;
        int middle;
        public BinarySerch()
        {
            rear = arr.Length;
            front = 0;
            middle = (front + rear) / 2;
        }

        int counter = 1;
        public int BinarySearch()
        {
            while (key != arr[middle])
            {
                counter++;
                if (rear == front)
                {
                    return arr[0];
                }
                else if (key > arr[middle])
                {
                    front = middle;
                    middle = (front + rear) / 2;
                }
                else if (key < arr[middle])
                {
                    rear = middle;
                    middle = (front + rear) / 2;
                }
            }

            int result = middle;
            return result;
        }

        public int BinarySearch(int key, int first = 0, int last = 8)
        {
            int middle = (first + last) / 2;

            if (arr[first] == key)
            {
                return first;
            }
            if (first == last)
            {
                return arr[first];
            }
            else if (key > arr[first])
            {
                return BinarySearch(key, middle + 1, last);
            }
            else
            {
                return BinarySearch(key, first, middle - 1);
            }
        }
    }
}

