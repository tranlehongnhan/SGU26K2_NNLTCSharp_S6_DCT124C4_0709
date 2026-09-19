using System;
using System.Reflection;

namespace NNLT_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("========== MENU CHÍNH CHƯƠNG TRÌNH ==========");
                Console.WriteLine("1. Bài tập LAB 1 (Bài 1 -> Bài 17)");
                Console.WriteLine("2. Bài tập LAB 2 (OOP)");
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("=============================================");
                Console.Write("Nhập lựa chọn của bạn: ");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        RunLab1();
                        break;
                    case "2":
                        RunLab2Menu();
                        break;
                    case "0":
                        Console.WriteLine("Đã thoát chương trình.");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Nhấn phím bất kỳ...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // ================= HELPER CHẠY BÀI TỰ ĐỘNG =================
        static void ChayBai(string fullClassName)
        {
            Type? loaiBai = Type.GetType(fullClassName);

            if (loaiBai == null)
            {
                Console.WriteLine("\n[THÔNG BÁO] Bài này chưa tạo file hoặc chưa được triển khai!");
                return;
            }

            MethodInfo? phuongThuc = loaiBai.GetMethod("Run");

            if (phuongThuc == null)
            {
                Console.WriteLine("\n[THÔNG BÁO] Bài này chưa có phương thức Run()!");
                return;
            }

            Console.Clear();
            phuongThuc.Invoke(null, null);
        }

        // ================= MENU LAB 1 =================
        static void RunLab1()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("================ MENU LAB 1 ================");
                for (int i = 1; i <= 17; i++)
                {
                    Console.WriteLine(i + ". Bai" + i);
                }
                Console.WriteLine("0. Quay lại Menu Chính");
                Console.WriteLine("============================================");
                Console.Write("Nhập số bài muốn chạy (1-17): ");

                if (!int.TryParse(Console.ReadLine(), out int bai))
                {
                    Console.WriteLine("Vui lòng nhập số!");
                    Console.ReadKey();
                    continue;
                }

                if (bai == 0) return;

                if (bai >= 1 && bai <= 17)
                {
                    // Thử tìm ở namespace mặc định hoặc namespace Lab1
                    string tenClass = "Bai" + bai;
                    if (Type.GetType(tenClass) != null)
                        ChayBai(tenClass);
                    else
                        ChayBai("Lab1." + tenClass);

                    Console.WriteLine("\nNhấn phím bất kỳ để quay lại...");
                    Console.ReadKey();
                }
            }
        }

        // ================= MENU CHÍNH LAB 2 =================
        static void RunLab2Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("================ MENU LAB 2 (OOP) ================");
                Console.WriteLine("1. Phần 1 (Bài 1.1 -> Bài 1.5)");
                Console.WriteLine("2. Phần 2 (Bài 2.1 -> Bài 2.5)");
                Console.WriteLine("3. Phần 3 (Bài 3.1 -> Bài 3.6)");
                Console.WriteLine("0. Quay lại Menu Chính");
                Console.WriteLine("==================================================");
                Console.Write("Nhập lựa chọn của bạn: ");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        RunLab2_Phan1();
                        break;
                    case "2":
                        RunLab2_Phan2();
                        break;
                    case "3":
                        RunLab2_Phan3();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // ---------- PHẦN 1: BÀI 1.1 -> 1.5 ----------
        static void RunLab2_Phan1()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("========== LAB 2 - PHẦN 1 ==========");
                Console.WriteLine("1. Bài 1.1: Quản lý Sinh viên (Tính tuổi)");
                Console.WriteLine("2. Bài 1.2: Lớp Point");
                Console.WriteLine("3. Bài 1.3: Lớp Person");
                Console.WriteLine("4. Bài 1.4: Lớp Phân Số");
                Console.WriteLine("5. Bài 1.5: Đơn thức");
                Console.WriteLine("0. Quay lại Menu Lab 2");
                Console.Write("Nhập lựa chọn: ");

                string choice = Console.ReadLine() ?? "";
                if (choice == "0") return;

                if (int.TryParse(choice, out int num) && num >= 1 && num <= 5)
                {
                    ChayBai("Lab2.Bai1_" + num);
                    Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                    Console.ReadKey();
                }
            }
        }

        // ---------- PHẦN 2: BÀI 2.1 -> 2.5 ----------
        static void RunLab2_Phan2()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("========== LAB 2 - PHẦN 2 ==========");
                Console.WriteLine("1. Bài 2.1");
                Console.WriteLine("2. Bài 2.2");
                Console.WriteLine("3. Bài 2.3");
                Console.WriteLine("4. Bài 2.4");
                Console.WriteLine("5. Bài 2.5");
                Console.WriteLine("0. Quay lại Menu Lab 2");
                Console.Write("Nhập lựa chọn: ");

                string choice = Console.ReadLine() ?? "";
                if (choice == "0") return;

                if (int.TryParse(choice, out int num) && num >= 1 && num <= 5)
                {
                    ChayBai("Lab2.Bai2_" + num);
                    Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                    Console.ReadKey();
                }
            }
        }

        // ---------- PHẦN 3: BÀI 3.1 -> 3.6 ----------
        static void RunLab2_Phan3()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("========== LAB 2 - PHẦN 3 ==========");
                Console.WriteLine("1. Bài 3.1");
                Console.WriteLine("2. Bài 3.2");
                Console.WriteLine("3. Bài 3.3");
                Console.WriteLine("4. Bài 3.4");
                Console.WriteLine("5. Bài 3.5");
                Console.WriteLine("6. Bài 3.6");
                Console.WriteLine("0. Quay lại Menu Lab 2");
                Console.Write("Nhập lựa chọn: ");

                string choice = Console.ReadLine() ?? "";
                if (choice == "0") return;

                if (int.TryParse(choice, out int num) && num >= 1 && num <= 6)
                {
                    ChayBai("Lab2.Bai3_" + num);
                    Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                    Console.ReadKey();
                }
            }
        }
    }
}