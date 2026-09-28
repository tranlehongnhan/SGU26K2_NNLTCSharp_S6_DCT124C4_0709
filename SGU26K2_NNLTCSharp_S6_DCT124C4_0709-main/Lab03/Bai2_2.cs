using System;
using System.Linq;

namespace Lab03
{
    public static class Bai2_2
    {
        public static void ThucHanh()
        {
            string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga", "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };

            var cauA = mangChuoi.Where(s => s.Length == 4).OrderBy(s => s[0]);
            Console.WriteLine("a. Chuỗi dài 4 ký tự sắp xếp theo chữ cái đầu: " + string.Join(", ", cauA));
        }
    }
}