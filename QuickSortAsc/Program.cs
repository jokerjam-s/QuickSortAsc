using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    partial class Program
    {
        //0, 2, -5, 5, 3, 7, 9, -1
        //0, 2, -5, 5, 3, 7, 9, -1
        static void Main(string[] args)
        {
            int[] arr = { 0, -5, 2, 3, 5, 9, -1, 7 };
            QuickSort(arr, 0, arr.Length - 1);
            Console.Write($"Отсортированный массив {string.Join(", ", arr)}");
        }


        static void QuickSort(int[] inputArray, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex) return;
            int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
            QuickSort(inputArray, minIndex, pivot - 1);
            QuickSort(inputArray, pivot + 1, maxIndex);
            return;
        }
        static int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
        {
            int pivotIndex = minIndex - 1;
            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (inputArray[i] < inputArray[maxIndex])
                {
                    pivotIndex++;
                    Swap(inputArray, i, pivotIndex);
                }
            }
            pivotIndex++;
            Swap(inputArray, pivotIndex, maxIndex);
            return pivotIndex;
        }
        static void Swap(int[] inputArray, int leftValue, int rightValue)
        {
            int temp = inputArray[leftValue];
            inputArray[leftValue] = inputArray[rightValue];
            inputArray[rightValue] = temp;
        }
    }
}