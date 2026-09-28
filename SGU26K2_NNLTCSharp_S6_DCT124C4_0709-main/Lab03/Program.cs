using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Bai2_1 ===");
            Bai2_1.ThucHanh();

            Console.WriteLine("\n=== Bai2_2 ===");
            Bai2_2.ThucHanh();

            Console.WriteLine("\n=== Bai3_1 ===");
            Bai3_1.ThucHanh();

            Console.WriteLine("\n=== Bai3_2 ===");
            Bai3_2.ThucHanh();

            Console.WriteLine("\n=== Bai5_1 ===");
            Bai5_1.ThucHanh();

            Console.WriteLine("\n=== Bai5_2 ===");
            Bai5_2.ThucHanh();

            Console.WriteLine("\n=== Bai6_1 ===");
            Bai6_1.ThucHanh();

            Console.WriteLine("\n=== Bai6_2 ===");
            Bai6_2.ThucHanh();

            Console.ReadKey();
        }
    }
}