using System;
using System.Linq;

namespace Lab03
{
    public static class Bai3_2
    {
        public static void ThucHanh()
        {
            string[] monAn = { "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì" };

            int soMonBanh = monAn.Count(s => s.StartsWith("Bánh "));
            Console.WriteLine($"Số món ăn bắt đầu bằng từ 'Bánh': {soMonBanh}");
        }
    }
}