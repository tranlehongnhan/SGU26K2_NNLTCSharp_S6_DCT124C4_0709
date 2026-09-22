using System;
using System.Collections.Generic;

namespace Lab2
{
    public class NhanVien
    {
        private string hoTen;
        private double mucLuong;
        private int soNgayVang;

        public NhanVien(string hoTen, double mucLuong, int soNgayVang)
        {
            this.hoTen = hoTen;
            this.mucLuong = mucLuong;
            this.soNgayVang = soNgayVang;
        }

        public double TinhLuong()
        {
            double luong = mucLuong - (soNgayVang * 100000);
            return luong < 0 ? 0 : luong;
        }

        public override string ToString()
        {
            return hoTen + " | Luong co ban: " + mucLuong + " | Vang: " + soNgayVang + " ngay | Thuc linh: " + TinhLuong();
        }
    }

    public class PhongBan
    {
        private List<NhanVien> dsNV = new List<NhanVien>();

        public void Add(NhanVien nv)
        {
            dsNV.Add(nv);
        }

        public double TinhTongLuong()
        {
            double tong = 0;
            for (int i = 0; i < dsNV.Count; i++)
            {
                tong += dsNV[i].TinhLuong();
            }
            return tong;
        }

        public void Output()
        {
            for (int i = 0; i < dsNV.Count; i++)
            {
                Console.WriteLine(dsNV[i].ToString());
            }
        }
    }

    public class Bai2_5
    {
        public static void Run()
        {
            Console.WriteLine("=== LAB 2 - BÀI 2.5: TÍNH LƯƠNG PHÒNG BAN ===");
            PhongBan pb = new PhongBan();
            pb.Add(new NhanVien("Nguyen Van A", 10000000, 2));
            pb.Add(new NhanVien("Tran Thi B", 12000000, 0));

            pb.Output();
            Console.WriteLine("-> TỔNG LƯƠNG PHÒNG BAN: " + pb.TinhTongLuong().ToString("N0") + " VNĐ");
        }
    }
}