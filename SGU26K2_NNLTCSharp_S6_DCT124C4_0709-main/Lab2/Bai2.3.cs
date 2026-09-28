using System;

namespace Lab2
{
    public class DaThuc
    {
        private double[] a; // Mảng n+1 hệ số
        private int n;      // Bậc đa thức

        public DaThuc()
        {
            n = 0;
            a = new double[1] { 0 };
        }

        public DaThuc(int bac)
        {
            n = bac < 0 ? 0 : bac;
            a = new double[n + 1];
        }

        // Indexer truy cập hệ số a_i
        public double this[int i]
        {
            get
            {
                if (i >= 0 && i <= n) return a[i];
                return 0;
            }
            set
            {
                if (i >= 0 && i <= n) a[i] = value;
            }
        }

        public double TinhGiaTri(double x)
        {
            double res = 0;
            for (int i = 0; i <= n; i++)
            {
                res += a[i] * Math.Pow(x, i);
            }
            return res;
        }

        public void Output()
        {
            Console.Write("P(x) = ");
            for (int i = n; i >= 0; i--)
            {
                if (i == n) Console.Write(a[i] + "x^" + i);
                else if (i == 1) Console.Write(" + " + a[i] + "x");
                else if (i == 0) Console.Write(" + " + a[i]);
                else Console.Write(" + " + a[i] + "x^" + i);
            }
            Console.WriteLine();
        }
    }

    public class Bai2_3
    {
        public static void Run()
        {
            Console.WriteLine("=== LAB 2 - BÀI 2.3: LỚP ĐA THỨC ===");
            // P(x) = 2 + 3x + 4x^2 (Bậc 2)
            DaThuc dt = new DaThuc(2);
            dt[0] = 2;
            dt[1] = 3;
            dt[2] = 4;

            dt.Output();
            double x = 2;
            Console.WriteLine("Giá trị P(" + x + ") = " + dt.TinhGiaTri(x));
        }
    }
}