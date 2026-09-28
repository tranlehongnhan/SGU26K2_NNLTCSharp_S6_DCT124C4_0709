using System;
using System.Collections.Generic;

namespace Lab2
{
    public abstract class NhanVien35
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }

        public NhanVien35(string ma, string ten)
        {
            MaNV = ma;
            HoTen = ten;
        }

        public abstract double TinhLuong();

        public virtual void XuatThongTin()
        {
            Console.WriteLine("Mã NV: " + MaNV + " | Họ tên: " + HoTen + " | Lương: " + TinhLuong().ToString("N0") + " VNĐ");
        }
    }

    public class NhanVienKinhDoanh35 : NhanVien35
    {
        public double LuongCoBan { get; set; }
        public int SoHopDong { get; set; }

        public NhanVienKinhDoanh35(string ma, string ten, double lcb, int hd)
            : base(ma, ten)
        {
            LuongCoBan = lcb;
            SoHopDong = hd;
        }

        public override double TinhLuong()
        {
            return LuongCoBan + (SoHopDong * 500000);
        }

        public override void XuatThongTin()
        {
            Console.WriteLine("[Kinh Doanh] Mã NV: " + MaNV + " | Họ tên: " + HoTen +
                              " | Số HD: " + SoHopDong + " | Lương: " + TinhLuong().ToString("N0") + " VNĐ");
        }
    }

    public class NhanVienSanXuat35 : NhanVien35
    {
        public int SoSanPham { get; set; }

        public NhanVienSanXuat35(string ma, string ten, int sp)
            : base(ma, ten)
        {
            SoSanPham = sp;
        }

        public override double TinhLuong()
        {
            double luong = SoSanPham * 1000;
            if (SoSanPham > 3000)
            {
                luong *= 1.05; // Thưởng thêm 5%
            }
            return luong;
        }

        public override void XuatThongTin()
        {
            Console.WriteLine("[Sản Xuất]  Mã NV: " + MaNV + " | Họ tên: " + HoTen +
                              " | Số SP: " + SoSanPham + " | Lương: " + TinhLuong().ToString("N0") + " VNĐ");
        }
    }

    public class Bai3_5
    {
        public static void Run()
        {
            Console.WriteLine("=== LAB 2 - BÀI 3.5: TÍNH LƯƠNG NHÂN VIÊN CÔNG TY ===");
            List<NhanVien35> ds = new List<NhanVien35>();
            ds.Add(new NhanVienKinhDoanh35("KD01", "Nguyễn Văn A", 5000000, 4));
            ds.Add(new NhanVienSanXuat35("SX01", "Trần Thị B", 3500));
            ds.Add(new NhanVienSanXuat35("SX02", "Lê Văn C", 2000));

            double tongLuong = 0;
            Console.WriteLine("\n--- DANH SÁCH NHÂN VIÊN ---");
            for (int i = 0; i < ds.Count; i++)
            {
                ds[i].XuatThongTin();
                tongLuong += ds[i].TinhLuong();
            }

            Console.WriteLine("\n=> TỔNG LƯƠNG CÔNG TY: " + tongLuong.ToString("N0") + " VNĐ");
        }
    }
}