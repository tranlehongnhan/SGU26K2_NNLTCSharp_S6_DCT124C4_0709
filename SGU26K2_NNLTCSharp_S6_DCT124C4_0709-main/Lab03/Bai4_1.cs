using System;
using System.Linq;

namespace Lab03
{
    public static class Bai4_1
    {
        public static void ThucHanh()
        {
            int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

            Console.WriteLine("Dãy số ban đầu: " + string.Join(", ", mangSo));

            // Sắp xếp tăng dần
            var mangTangDan = mangSo.OrderBy(x => x);
            Console.WriteLine("Dãy số tăng dần: " + string.Join(", ", mangTangDan));

            // Sắp xếp giảm dần
            var mangGiamDan = mangSo.OrderByDescending(x => x);
            Console.WriteLine("Dãy số giảm dần: " + string.Join(", ", mangGiamDan));
        }
    }
}