using System;
using System.Linq;

namespace Lab03
{
    public static class Bai3_1
    {
        public static void ThucHanh()
        {
            int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

            Console.WriteLine($"a. Tổng số phần tử: {mangSo.Count()}");
            Console.WriteLine($"   Số phần tử chẵn: {mangSo.Count(x => x % 2 == 0)}");
        }
    }
}