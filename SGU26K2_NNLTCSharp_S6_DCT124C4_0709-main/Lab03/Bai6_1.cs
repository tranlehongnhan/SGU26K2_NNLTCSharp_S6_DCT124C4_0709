using System;
using System.Linq;

namespace Lab03
{
    public static class Bai6_1
    {
        public static void ThucHanh()
        {
            var dsMon = DuLieu.DS_Mon();
            var dsHe = DuLieu.DS_He();

            Console.WriteLine("Danh sách Hệ đào tạo:");
            foreach (var h in dsHe)
            {
                Console.WriteLine($"   - Mã hệ: {h.MaHe} | Tên hệ: {h.TenHe}");
            }

            Console.WriteLine("\nDanh sách Môn học thuộc Hệ 'KTV':");
            var monKTV = dsMon.Where(m => m.He == "KTV");
            foreach (var m in monKTV)
            {
                Console.WriteLine($"   - [{m.MaMon}] {m.TenMon}");
            }
        }
    }
}