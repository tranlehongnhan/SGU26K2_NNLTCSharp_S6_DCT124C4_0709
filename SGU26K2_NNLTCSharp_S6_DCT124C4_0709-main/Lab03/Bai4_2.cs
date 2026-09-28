using System;
using System.Linq;

namespace Lab03
{
    public static class Bai4_2
    {
        public static void ThucHanh()
        {
            string[] chuoiHocTap = { "C#", "LINQ", "ASP.NET", "Entity Framework", "SQL Server", "HTML/CSS" };

            Console.WriteLine("Danh sách ban đầu: " + string.Join(", ", chuoiHocTap));

            // Sắp xếp theo chiều dài tăng dần
            var tangDanTheoDoDai = chuoiHocTap.OrderBy(s => s.Length);
            Console.WriteLine("Sắp xếp theo độ dài tăng dần: " + string.Join(", ", tangDanTheoDoDai));

            // Sắp xếp theo chiều dài giảm dần
            var giamDanTheoDoDai = chuoiHocTap.OrderByDescending(s => s.Length);
            Console.WriteLine("Sắp xếp theo độ dài giảm dần: " + string.Join(", ", giamDanTheoDoDai));
        }
    }
}