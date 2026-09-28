using System;
using System.Linq;

namespace Lab03
{
    public static class Bai6_2
    {
        public static void ThucHanh()
        {
            var dsMon = DuLieu.DS_Mon();
            var dsHe = DuLieu.DS_He();

            var ketQua = from h in dsHe
                         join m in dsMon on h.MaHe equals m.He
                         select new { h.TenHe, m.MaMon, m.TenMon };

            Console.WriteLine("Kết quả kết hợp (Join) giữa Môn học và Hệ đào tạo:");
            foreach (var item in ketQua)
            {
                Console.WriteLine($"   - [{item.TenHe}] {item.TenMon}");
            }
        }
    }
}