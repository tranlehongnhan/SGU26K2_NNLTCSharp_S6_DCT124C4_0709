using System;
using System.Collections.Generic;

namespace Lab2
{
    public class DayPhanSo
    {
        private List<PhanSo> ds;

        public DayPhanSo()
        {
            ds = new List<PhanSo>();
        }

        public void Add(PhanSo ps)
        {
            ds.Add(ps);
        }

        public PhanSo TinhTong()
        {
            PhanSo tong = new PhanSo(0, 1);
            for (int i = 0; i < ds.Count; i++)
            {
                tong = tong + ds[i];
            }
            return tong;
        }

        public void Output()
        {
            for (int i = 0; i < ds.Count; i++)
            {
                Console.Write(ds[i].ToString() + (i == ds.Count - 1 ? "" : " + "));
            }
        }
    }

    public class Bai2_4
    {
        public static void Run()
        {
            Console.WriteLine("=== LAB 2 - BÀI 2.4: DÃY PHÂN SỐ ===");
            DayPhanSo day = new DayPhanSo();
            day.Add(new PhanSo(1, 2));
            day.Add(new PhanSo(1, 3));
            day.Add(new PhanSo(1, 4));

            Console.Write("Biểu thức: ");
            day.Output();
            Console.WriteLine("\nTổng dãy phân số: " + day.TinhTong().ToString());
        }
    }
}