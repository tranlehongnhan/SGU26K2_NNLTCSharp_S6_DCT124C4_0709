namespace Lab03;

public class Lab03
{
    public static void Chay()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("================================");
            Console.WriteLine("            LAB 3");
            Console.WriteLine("================================");
            Console.WriteLine("1. Bai2_1");
            Console.WriteLine("2. Bai2_2");
            Console.WriteLine("3. Bai3_1");
            Console.WriteLine("4. Bai3_2");
            Console.WriteLine("5. Bai4_1");
            Console.WriteLine("6. Bai4_2");
            Console.WriteLine("7. Bai5_1");
            Console.WriteLine("8. Bai5_2");
            Console.WriteLine("9. Bai6_1");
            Console.WriteLine("10. Bai6_2");
            Console.WriteLine("0. Quay lai");
            Console.WriteLine("================================");

            Console.Write("\nChon bai: ");
            string? chon = Console.ReadLine();

            switch (chon)
            {
                case "1":
                    Bai2_1.ThucHanh();
                    break;

                case "2":
                    Bai2_2.ThucHanh();
                    break;

                case "3":
                    Bai3_1.ThucHanh();
                    break;

                case "4":
                    Bai3_2.ThucHanh();
                    break;

                case "5":
                    Bai4_1.ThucHanh();
                    break;

                case "6":
                    Bai4_2.ThucHanh();
                    break;

                case "7":
                    Bai5_1.ThucHanh();
                    break;

                case "8":
                    Bai5_2.ThucHanh();
                    break;

                case "9":
                    Bai6_1.ThucHanh();
                    break;

                case "10":
                    Bai6_2.ThucHanh();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("\nKhong hop le!");
                    Console.WriteLine("Nhan phim bat ky...");
                    Console.ReadKey();
                    continue;
            }

            Console.WriteLine("\nNhan phim bat ky de quay lai menu Lab 3...");
            Console.ReadKey();
        }
    }
}