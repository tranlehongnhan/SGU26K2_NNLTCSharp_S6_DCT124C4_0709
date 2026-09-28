using System;
using System.Collections.Generic;

namespace Lab2
{
    public abstract class ThiSinh36
    {
        public string Sbd { get; set; }
        public string HoTen { get; set; }
        public double Bai1 { get; set; }
        public double Bai2 { get; set; }
        public double Bai3 { get; set; }

        public ThiSinh36(string sbd, string hoTen, double b1, double b2, double b3)
        {
            Sbd = sbd;
            HoTen = hoTen;
            Bai1 = b1;
            Bai2 = b2;
            Bai3 = b3;
        }

        public abstract double TongDiem();

        public virtual void XuatThongTin()
        {
            Console.WriteLine("SBD: " + Sbd + " | Họ tên: " + HoTen + " | Tổng điểm: " + TongDiem());
        }
    }

    public class ThiSinhChuyen36 : ThiSinh36
    {
        public double TiengAnh { get; set; }

        public ThiSinhChuyen36(string sbd, string hoTen, double b1, double b2, double b3, double ta)
            : base(sbd, hoTen, b1, b2, b3)
        {
            TiengAnh = ta;
        }

        public override double TongDiem()
        {
            double diemCong = 0;
            if (TiengAnh >= 7 && TiengAnh <= 8)
                diemCong = 1;
            else if (TiengAnh >= 9 && TiengAnh <= 10)
                diemCong = 2;

            return Bai1 + Bai2 + Bai3 + diemCong;
        }

        public override void XuatThongTin()
        {
            Console.WriteLine("[Chuyên]   SBD: " + Sbd + " | Họ tên: " + HoTen +
                              " | Điểm bài (1, 2, 3): (" + Bai1 + ", " + Bai2 + ", " + Bai3 + ")" +
                              " | Tiếng Anh: " + TiengAnh + " => Tổng điểm: " + TongDiem());
        }
    }

    public class ThiSinhSieuCup36 : ThiSinh36
    {
        public double Csdl { get; set; }

        public ThiSinhSieuCup36(string sbd, string hoTen, double b1, double b2, double b3, double csdl)
            : base(sbd, hoTen, b1, b2, b3)
        {
            Csdl = csdl;
        }

        public override double TongDiem()
        {
            return Bai1 + Bai2 + Bai3 + Csdl;
        }

        public override void XuatThongTin()
        {
            Console.WriteLine("[Siêu Cúp] SBD: " + Sbd + " | Họ tên: " + HoTen +
                              " | Điểm bài (1, 2, 3): (" + Bai1 + ", " + Bai2 + ", " + Bai3 + ")" +
                              " | CSDL: " + Csdl + " => Tổng điểm: " + TongDiem());
        }
    }

    public class Bai3_6
    {
        public static void Run()
        {
            Console.WriteLine("=== LAB 2 - BÀI 3.6: TÍNH ĐIỂM THÍ SINH ===");
            List<ThiSinh36> ds = new List<ThiSinh36>();

            ds.Add(new ThiSinhChuyen36("C01", "Nguyễn Văn A", 8, 7, 9, 9.5));
            ds.Add(new ThiSinhChuyen36("C02", "Trần Thị B", 6, 7, 8, 7.5));
            ds.Add(new ThiSinhSieuCup36("SC01", "Lê Văn C", 9, 9, 10, 8.5));

            Console.WriteLine("\n--- KẾT QUẢ CUỘC THI ---");
            for (int i = 0; i < ds.Count; i++)
            {
                ds[i].XuatThongTin();
            }
        }
    }
}