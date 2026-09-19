using System;
using System.Reflection; //[cite: 4] Dùng cho Reflection của Lab 1
using Lab2;               // Dùng cho các bài của Lab 2

class Program
{
    // ====================================================
    // 1. MENU TỔNG (CHỌN LAB 1 HOẶC LAB 2)
    // ====================================================
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("================ MENU CHÍNH ================");
            Console.WriteLine("1. Chạy LAB 1 (Bài 1 -> Bài 17)");
            Console.WriteLine("2. Chạy LAB 2 (Lập trình hướng đối tượng)");
            Console.WriteLine("0. Thoát chương trình");
            Console.Write("\nNhập lựa chọn của bạn: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunLab1(); // Chạy Lab 1
                    break;
                case "2":
                    RunLab2(); // Chạy Lab 2
                    break;
                case "0":
                    Console.WriteLine("Đã thoát chương trình.");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ! Nhấn phím bất kỳ để chọn lại...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // ====================================================
    // 2. CODE LAB 1(DÙNG REFLECTION TỰ ĐỘNG GỌI BÀI)
    // ====================================================
    static void RunLab1()
    {
        while (true)
        {
            Console.Clear(); //[cite: 6]

            Console.WriteLine("===== BAI TAP C# ====="); //[cite: 6]
            Console.WriteLine("Bai1"); //[cite: 6]
            Console.WriteLine("Bai2"); //[cite: 6]
            Console.WriteLine("Bai3"); //[cite: 6]
            Console.WriteLine("Bai4"); //[cite: 6]
            Console.WriteLine("Bai5"); //[cite: 6]
            Console.WriteLine("Bai6"); //[cite: 6]
            Console.WriteLine("Bai7"); //[cite: 6]
            Console.WriteLine("Bai8"); //[cite: 6]
            Console.WriteLine("Bai9"); //[cite: 6]
            Console.WriteLine("Bai10"); //[cite: 6]
            Console.WriteLine("Bai11"); //[cite: 6]
            Console.WriteLine("Bai12"); //[cite: 6]
            Console.WriteLine("Bai13"); //[cite: 6]
            Console.WriteLine("Bai14"); //[cite: 6]
            Console.WriteLine("Bai15"); //[cite: 6]
            Console.WriteLine("Bai16"); //[cite: 6]
            Console.WriteLine("Bai17"); //
            Console.WriteLine("0. Thoat"); //[cite: 7]

            Console.Write("\nNhap so bai muon chay: "); //[cite: 7]

            if (!int.TryParse(Console.ReadLine(), out int bai)) //[cite: 7]
            {
                Console.WriteLine("Vui long nhap so!"); //[cite: 7]
                Console.ReadKey(); //[cite: 7]
                continue; //[cite: 7]
            }

            if (bai == 0) //[cite: 7]
            {
                break; // Quay về Menu Chính
            }

            if (bai < 1 || bai > 17) //[cite: 7]
            {
                Console.WriteLine("Bai khong ton tai!"); //[cite: 7]
                Console.ReadKey(); //[cite: 7]
                continue; //[cite: 7]
            }

            // Hỗ trợ tìm class cả khi nằm trong namespace Lab1 hoặc không có namespace
            Type? loaiBai = Type.GetType("Lab1.Bai" + bai) ?? Type.GetType("Bai" + bai); //[cite: 7]

            if (loaiBai == null) //[cite: 7]
            {
                Console.WriteLine("\nBai nay chua duoc lam!"); //[cite: 8]
                Console.ReadKey(); //[cite: 8]
                continue; //[cite: 8]
            }

            MethodInfo? phuongThuc = loaiBai.GetMethod("Run"); //[cite: 8]

            if (phuongThuc == null) //[cite: 8]
            {
                Console.WriteLine("\nBai nay chua co phuong thuc Run()!"); //[cite: 8]
                Console.ReadKey(); //[cite: 8]
                continue; //[cite: 8]
            }

            Console.Clear(); //[cite: 8]

            phuongThuc.Invoke(null, null); //[cite: 8]

            Console.WriteLine("\nNhan phim bat ky de quay lai menu..."); //[cite: 8]
            Console.ReadKey(); //[cite: 8]
        }
    }

    // ====================================================
    // 3. MENU CHẠY CÁC BÀI LAB 2
    // ====================================================
    static void RunLab2()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("================ MENU LAB 2 (OOP) ================");
            Console.WriteLine("1. Bài 1.1: Quản lý Sinh viên (Tính tuổi)");
            Console.WriteLine("2. Bài 1.2: Lớp Point");
            Console.WriteLine("3. Bài 1.3: Lớp Person");
            Console.WriteLine("4. Bài 1.4: Lớp Phân Số");
            Console.WriteLine("5. Bài 1.5: Đơn thức");
            Console.WriteLine("0. Quay lại Menu Chính");
            Console.Write("\nNhập lựa chọn bài Lab 2: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Lab2.Bai1_1.Run(); // Gọi hàm Run trong file Lab2/Bai1.1.cs
                    Console.WriteLine("\nNhấn phím bất kỳ để quay lại...");
                    Console.ReadKey();
                    break;
                case "2":
                    // Lab2.Bai1_2.Run();
                    Console.WriteLine("Bài 1.2 chưa cập nhật. Nhấn phím bất kỳ để quay lại...");
                    Console.ReadKey();
                    break;
                case "0":
                    return; // Quay lại Menu Chính
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}