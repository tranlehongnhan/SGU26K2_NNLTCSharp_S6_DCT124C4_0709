using System;
using System.Linq;

namespace Lab03
{
    public static class Bai2_1
    {
        public static void ThucHanh()
        {
            int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };

            var cauA = mangSo.Where(x => x % 4 == 0 && x % 3 == 0);
            Console.WriteLine("a. Phần tử chia hết cho 4 và 3: " + string.Join(", ", cauA));

            var cauB = mangSo.Where(x => x <= 3);
            Console.WriteLine("b. Phần tử <= 3: " + string.Join(", ", cauB));

            var cauC = mangSo.Select(x => x % 2 == 0 ? x / 2 : x);
            Console.WriteLine("c. Dãy mới: " + string.Join(", ", cauC));
        }
    }
}