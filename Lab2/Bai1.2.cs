using System;

namespace Lab2
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        // Khoảng cách
        public double TinhKhoangCach(Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - this.X, 2) + Math.Pow(b.Y - this.Y, 2));
        }

        public static double TinhKhoangCach(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }

        // Trung điểm
        public Point TimTrungDiem(Point b)
        {
            return new Point((this.X + b.X) / 2.0, (this.Y + b.Y) / 2.0);
        }

        public static Point TimTrungDiem(Point a, Point b)
        {
            return new Point((a.X + b.X) / 2.0, (a.Y + b.Y) / 2.0);
        }

        // Toán tử
        public static Point operator +(Point a, Point b) => new Point(a.X + b.X, a.Y + b.Y);
        public static Point operator -(Point a, Point b) => new Point(a.X - b.X, a.Y - b.Y);
        public static Point operator -(Point a) => new Point(-a.X, -a.Y);
    }

    public class Bai1_2
    {
        public static void Run()
        {
            Console.WriteLine("=== LAB 2 - BÀI 1.2: LỚP POINT (ĐIỂM 2D) ===");
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 4);

            Console.WriteLine($"Điểm p1: {p1}");
            Console.WriteLine($"Điểm p2: {p2}");
            Console.WriteLine($"Khoảng cách p1 -> p2: {p1.TinhKhoangCach(p2)}");
            Console.WriteLine($"Trung điểm p1 và p2: {Point.TimTrungDiem(p1, p2)}");
            Console.WriteLine($"p1 + p2 = {p1 + p2}");
            Console.WriteLine($"-p2 = {-p2}");
        }
    }
}