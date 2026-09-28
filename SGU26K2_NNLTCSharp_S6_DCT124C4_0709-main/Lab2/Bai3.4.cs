using System;
using System.Collections.Generic;

namespace Lab2
{
    public class MenuItem34
    {
        public string Title { get; set; }
        public Action Action { get; set; }

        public MenuItem34(string title, Action action)
        {
            Title = title;
            Action = action;
        }
    }

    public class ConsoleMenu34
    {
        private List<MenuItem34> items = new List<MenuItem34>();

        public void AddOption(string title, Action action)
        {
            items.Add(new MenuItem34(title, action));
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n========== CONSOLE MENU ==========");
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + items[i].Title);
                }
                Console.WriteLine("0. Thoát Menu");
                Console.Write("Nhập lựa chọn của bạn: ");

                string choice = Console.ReadLine() ?? "";
                if (choice == "0") break;

                if (int.TryParse(choice, out int index) && index >= 1 && index <= items.Count)
                {
                    items[index - 1].Action.Invoke();
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                }
            }
        }
    }

    public class Bai3_4
    {
        public static void GiaiPTBac2()
        {
            Console.WriteLine("\n--- PHƯƠNG TRÌNH BẬC 2: ax^2 + bx + c = 0 ---");
            Console.Write("Nhập a: ");
            if (!double.TryParse(Console.ReadLine(), out double a)) a = 1;
            Console.Write("Nhập b: ");
            if (!double.TryParse(Console.ReadLine(), out double b)) b = -3;
            Console.Write("Nhập c: ");
            if (!double.TryParse(Console.ReadLine(), out double c)) c = 2;

            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine(c == 0 ? "Phương trình vô số nghiệm." : "Phương trình vô nghiệm.");
                else
                    Console.WriteLine("Phương trình bậc 1 có nghiệm: x = " + (-c / b));
                return;
            }

            double delta = b * b - 4 * a * c;
            if (delta < 0)
                Console.WriteLine("Phương trình vô nghiệm.");
            else if (delta == 0)
                Console.WriteLine("Phương trình có nghiệm kép x = " + (-b / (2 * a)));
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phương trình có 2 nghiệm: x1 = " + x1 + ", x2 = " + x2);
            }
        }

        public static void Run()
        {
            Console.WriteLine("=== LAB 2 - BÀI 3.4: CONSOLE MENU TỔNG QUÁT ===");
            ConsoleMenu34 menu = new ConsoleMenu34();
            menu.AddOption("Giải phương trình bậc 2", GiaiPTBac2);
            menu.AddOption("Thông tin ứng dụng", () => Console.WriteLine("\nỨng dụng ConsoleMenu mở rộng qua Action/Delegate."));
            menu.Show();
        }
    }
}