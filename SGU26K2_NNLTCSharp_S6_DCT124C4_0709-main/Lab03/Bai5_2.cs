using System;
using System.Linq;

namespace Lab03
{
    public static class Bai5_2
    {
        public static void ThucHanh()
        {
            var dsMon = DuLieu.DS_Mon();
            Console.WriteLine($"Tổng số môn học trong danh sách: {dsMon.Count}");
        }
    }
}