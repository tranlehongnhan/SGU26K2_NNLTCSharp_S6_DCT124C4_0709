using System;

namespace Lab2
{
    public class SinhVien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }

        public SinhVien() { }

        public SinhVien(string hoTen, int namSinh)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
        }

        public int TinhTuoi()
        {
            return DateTime.Now.Year - NamSinh;
        }
    }

    // Class Runner dùng để chạy thử riêng Bài 1.1
    public class Bai1_1
    {
        public static void Run()
        {
            Console.WriteLine("=== LAB 2 - BÀI 1.1: TÍNH TUỔI SINH VIÊN ===");
            SinhVien sv = new SinhVien();
            sv.Nhap();
            Console.WriteLine($"Sinh vien: {sv.HoTen} | Tuoi: {sv.TinhTuoi()}");
        }
    }
}