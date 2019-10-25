using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public static class Program
    {

        static void Main(string[] args) { }

        public static int Min(int[] arr)
        {

            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }

        public static int Max(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        public static int Imin(int[] arr)
        {
            int imin = 0;
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    imin = i;
                }
            }
            return imin;
        }
        public static int Imax(int[] arr)
        {
            int imax = 0;
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    imax = i;
                }
            }
            return imax;
        }

        public static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                    sum = sum + arr[i];
            }
            return sum;
        }

        public static int[] Reverse(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int c = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = c;
            }
            return arr;
        }

        public static int N(int[] arr)
        {
            int n = 0;
            for (int i = 0; i <= arr.Length; i++)
            {
                if (i % 2 == 0)
                    n = n + 1;
            }
            return n;
        }

        public static int[] Reverse2(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int c = arr[i];
                arr[i] = arr[arr.Length / 2 + i];
                arr[arr.Length / 2 + i] = c;
            }

            return arr;
        }

        public static int[] bubble(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = 1; j < arr.Length - i; j++)
                    if (arr[j] < arr[j - 1])
                    {
                        int c = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = c;
                    }
            return arr;
        }

        public static int[] Insert(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int c = arr[i];
                int j = i - 1;
                while (j >= 0)
                {
                    if (c < arr[j])
                    {
                        arr[j + 1] = arr[j];
                    }
                    else
                    {
                        arr[j + 1] = c;
                        break;
                    }
                    j--;
                }
                if (j == -1)
                    arr[0] = c;
            }
            return arr;
        }

        public static int[] select(int[] array)
        {

            int tmp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                tmp = array[i];
                array[i] = array[min];
                array[min] = tmp;
            }
            return array;
        }

        public static int[] shell(int[] array) {
            int n = array.Length;
            int i = Convert.ToInt16(Math.Round(n / 2.0));
            while (i > 0)
            {
                for (int j = 0; j < n; j++)
                {
                    int k = j, t = array[j];
                    while (k >= i && array[k - i] > t)
                    {
                        array[k] = array[k - i]; k -= i;
                    }
                    array[k] = t;
                }
                i = (i == 2) ? 1 : (i * 5 / 11);
            }
            return array;
        }
        public static int[] heap(int[] array)
        {
            int n = array.Length;
            int i = Convert.ToInt16(Math.Floor(n / 2.0));
            int j, k, t;
            while (true)
            {
                if (i > 0)
                {
                    t = array[--i];
                }
                else
                {
                    n--;
                    if (n == 0)
                    {
                        foreach (int a in array)
                        {
                            Console.WriteLine(a);
                        }
                        break;
                    }
                    t = array[n]; array[n] = array[0];
                }
                j = i; k = j * 2 + 1;
                while (k < n)
                {
                    if (k + 1 < n && array[k + 1] > array[k])
                    {
                        k++;
                    }
                    if (array[k] > t)
                    {
                        array[j] = array[k]; j = k; k = j * 2 + 1;
                    }
                    else break;
                }
                array[j] = t;
            }
            return array;
        }

        public static int[] quick(int[] items) { 

            void swap(int[] item, int leftIndex, int rightIndex)
            {
                int temp = items[leftIndex];
                item[leftIndex] = item[rightIndex];
                item[rightIndex] = temp;
            }

            int partition(int[] item, int left, int right)
            {
                int q = Convert.ToInt16(Math.Floor((right + left) / 2.0));
                int pivot = items[q], //middle element
                i = left, //left pointer
                j = right; //right pointer
                while (i <= j)
                {
                    while (items[i] < pivot)
                    {
                        i++;
                    }

                    while (items[j] > pivot)
                    {
                        j--;
                    }
                    if (i <= j)
                    {
                        swap(items, i, j); //swapping two elements
                        i++;
                        j--;
                    }
                }
                return i;
            }

            int[] quickSort(int[] item, int left, int right)
            {
                int index;
                if (item.Length > 1)
                {
                    index = partition(item, left, right); //index returned from partition
                    if (left < index - 1)
                    { //more elements on the left side of the pivot
                        quickSort(item, left, index - 1);
                    }
                    if (index < right)
                    { //more elements on the right side of the pivot
                        quickSort(item, index, right);
                    }
                }
                return items;
            }
            // first call to quick sort
            int[] sortedArray = quickSort(items, 0, items.Length - 1);
                  foreach (int a in sortedArray){
                      Console.Write(a + " ");
                  }
            return items;
        }

    }
}