using System;

namespace Lab2
{
    public class Bai3_3
    {
        // Delegate so sánh tổng quát
        public delegate int SoSanhDelegate<T>(T x, T y);

        // Phương thức sắp xếp dùng Delegate
        public static void SapXepDelegate<T>(T[] arr, SoSanhDelegate<T> compare)
        {
            if (arr == null || compare == null) return;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (compare(arr[i], arr[j]) > 0)
                    {
                        T temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public static void Run()
        {
            Console.WriteLine("=== LAB 2 - BÀI 3.3: SẮP XẾP MẢNG BẰNG DELEGATE ===");
            double[] arr = { 3.5, 1.2, 8.9, 2.4, 0.5 };

            Console.WriteLine("Mảng ban đầu: " + string.Join(", ", arr));
            // Truyền hàm so sánh qua biểu thức Lambda
            SapXepDelegate(arr, (x, y) => x.CompareTo(y));
            Console.WriteLine("Mảng sau khi sắp xếp: " + string.Join(", ", arr));
        }
    }
}