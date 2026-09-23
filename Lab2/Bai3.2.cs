using System;
using System.Collections.Generic;

namespace Lab2
{
    public class Bai3_2
    {
        // Phương thức sắp xếp tổng quát mô phỏng Array.Sort bằng IComparer<T>
        public static void SapXep<T>(T[] arr, IComparer<T> comparer)
        {
            if (arr == null || comparer == null) return;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (comparer.Compare(arr[i], arr[j]) > 0)
                    {
                        T temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        // Lớp triển khai IComparer<int> để so sánh số nguyên
        public class CompareInt : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return x.CompareTo(y);
            }
        }

        public static void Run()
        {
            Console.WriteLine("=== LAB 2 - BÀI 3.2: SẮP XẾP MẢNG TỔNG QUÁT BẰNG INTERFACE ===");
            int[] numbers = { 25, 10, 50, 5, 30 };

            Console.WriteLine("Mảng ban đầu: " + string.Join(", ", numbers));
            SapXep(numbers, new CompareInt());
            Console.WriteLine("Mảng sau khi sắp xếp: " + string.Join(", ", numbers));
        }
    }
}