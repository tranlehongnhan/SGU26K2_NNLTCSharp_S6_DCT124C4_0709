using System;

namespace Lab2
{
    public class DonThuc
    {
        private double a; // Hệ số
        private int n;    // Bậc

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public int N
        {
            get { return n; }
            set { n = value < 0 ? 0 : value; }
        }

        public DonThuc()
        {
            a = 0;
            n = 0;
        }

        public DonThuc(double a, int n)
        {
            this.a = a;
            this.n = n < 0 ? 0 : n;
        }

        public double TinhGiaTri(double x)
        {
            return a * Math.Pow(x, n);
        }

        public DonThuc DaoHam()
        {
            if (n == 0)
            {
                return new DonThuc(0, 0);
            }
            return new DonThuc(a * n, n - 1);
        }

        public override string ToString()
        {
            if (n == 0)
            {
                return a.ToString();
            }
            if (n == 1)
            {
                return a + "x";
            }
            return a + "x^" + n;
        }
    }

    public class Bai1_5
    {
        public static void Run()
        {
            Console.WriteLine("=== LAB 2 - BÀI 1.5: LỚP ĐƠN THỨC ===");

            DonThuc dt = new DonThuc(3, 2); // 3x^2
            Console.WriteLine("Đơn thức P(x) = " + dt.ToString());

            double x = 2;
            Console.WriteLine("Giá trị P(" + x + ") = " + dt.TinhGiaTri(x));

            DonThuc dh = dt.DaoHam();
            Console.WriteLine("Đạo hàm P'(x) = " + dh.ToString());
        }
    }
}