using System;

namespace Lab2
{
    public class PhanSo
    {
        private int tuSo;
        private int mauSo;

        public int TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }

        public int MauSo
        {
            get { return mauSo; }
            set { mauSo = value == 0 ? 1 : value; }
        }

        public PhanSo()
        {
            tuSo = 0;
            mauSo = 1;
        }

        public PhanSo(int tu, int mau)
        {
            tuSo = tu;
            mauSo = mau == 0 ? 1 : mau;
            RutGon();
        }

        public PhanSo(PhanSo ps)
        {
            tuSo = ps.tuSo;
            mauSo = ps.mauSo;
        }

        private int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }

        public void RutGon()
        {
            int u = UCLN(tuSo, mauSo);
            tuSo = tuSo / u;
            mauSo = mauSo / u;
            if (mauSo < 0)
            {
                tuSo = -tuSo;
                mauSo = -mauSo;
            }
        }

        public override string ToString()
        {
            if (mauSo == 1)
            {
                return tuSo.ToString();
            }
            return tuSo + "/" + mauSo;
        }

        // Toán tử số học (+, -, *, /)
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.tuSo * b.mauSo + b.tuSo * a.mauSo, a.mauSo * b.mauSo);
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.tuSo * b.mauSo - b.tuSo * a.mauSo, a.mauSo * b.mauSo);
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.tuSo * b.tuSo, a.mauSo * b.mauSo);
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.tuSo * b.mauSo, a.mauSo * b.tuSo);
        }

        // Toán tử so sánh (>, <, >=, <=)
        public static bool operator >(PhanSo a, PhanSo b)
        {
            return a.tuSo * b.mauSo > b.tuSo * a.mauSo;
        }

        public static bool operator <(PhanSo a, PhanSo b)
        {
            return a.tuSo * b.mauSo < b.tuSo * a.mauSo;
        }

        public static bool operator >=(PhanSo a, PhanSo b)
        {
            return a.tuSo * b.mauSo >= b.tuSo * a.mauSo;
        }

        public static bool operator <=(PhanSo a, PhanSo b)
        {
            return a.tuSo * b.mauSo <= b.tuSo * a.mauSo;
        }
    }

    public class Bai1_4
    {
        public static void Run()
        {
            Console.WriteLine("=== LAB 2 - BÀI 1.4: LỚP PHÂN SỐ ===");

            PhanSo ps1 = new PhanSo(2, 4);
            PhanSo ps2 = new PhanSo(1, 3);

            Console.WriteLine("Phân số 1 (sau rút gọn): " + ps1.ToString());
            Console.WriteLine("Phân số 2: " + ps2.ToString());

            PhanSo tong = ps1 + ps2;
            PhanSo hieu = ps1 - ps2;
            PhanSo tich = ps1 * ps2;
            PhanSo thuong = ps1 / ps2;

            Console.WriteLine(ps1.ToString() + " + " + ps2.ToString() + " = " + tong.ToString());
            Console.WriteLine(ps1.ToString() + " - " + ps2.ToString() + " = " + hieu.ToString());
            Console.WriteLine(ps1.ToString() + " * " + ps2.ToString() + " = " + tich.ToString());
            Console.WriteLine(ps1.ToString() + " / " + ps2.ToString() + " = " + thuong.ToString());
            Console.WriteLine("ps1 > ps2: " + (ps1 > ps2));
        }
    }
}