using System;
using System.Linq;

namespace Lab03
{
    public static class Bai5_1
    {
        public static void ThucHanh()
        {
            var dsMon = DuLieu.DS_Mon();

            Console.WriteLine("Môn học thuộc hệ 'CD':");
            var monCD = dsMon.Where(m => m.He == "CD");
            foreach (var m in monCD)
            {
                Console.WriteLine($"   - [{m.MaMon}] {m.TenMon}");
            }
        }
    }
}