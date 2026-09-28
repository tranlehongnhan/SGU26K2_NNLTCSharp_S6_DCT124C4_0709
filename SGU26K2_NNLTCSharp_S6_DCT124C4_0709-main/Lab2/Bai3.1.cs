using System;

namespace Lab2
{
    // Đổi tên thành SinhVien31 để tránh đụng độ tên với các bài khác trong Lab2
    public class SinhVien31 : IComparable<SinhVien31>
    {
        public string HoTen { get; set; }
        public double DiemTB { get; set; }

        public SinhVien31()
        {
            HoTen = "";
            DiemTB = 0;
        }

        public SinhVien31(string name, double diem)
        {
            HoTen = name;
            DiemTB = diem;
        }

        // So sánh theo ĐTB tăng dần
        public int CompareTo(SinhVien31? other)
        {
            if (other == null) return 1;
            return this.DiemTB.CompareTo(other.DiemTB);
        }

        public override string ToString()
        {
            return HoTen + " - ĐTB: " + DiemTB;
        }
    }

    public class Bai3_1
    {
        public static void Run()
        {
            Console.WriteLine("=== LAB 2 - BÀI 3.1: SẮP XẾP DÙNG ARRAY.SORT ===");

            SinhVien31[] ds = new SinhVien31[]
            {
                new SinhVien31("Nguyen Van A", 7.5),
                new SinhVien31("Tran Van B", 9.0),
                new SinhVien31("Le Thi C", 6.0)
            };

            // Hàm sắp xếp tự động của C#
            Array.Sort(ds);

            Console.WriteLine("Danh sách sau khi sắp xếp tăng dần theo ĐTB:");
            for (int i = 0; i < ds.Length; i++)
            {
                Console.WriteLine(ds[i].ToString());
            }
        }
    }
}