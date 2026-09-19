using System;

namespace ThucHanhOOP
{
    class Point
    {
        private double x;
        private double y;

        public double X { => x; set => x = value; }
        public double Y { => y; set => y = value; }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Input()
        {
            Console.Write("Nhap x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }

        // Toan tu
        public static Point operator +(Point a, Point b) => new Point(a.x + b.x, a.y + b.y);
        public static Point operator -(Point a, Point b) => new Point(a.x - b.x, a.y - b.y);
        public static Point operator -(Point a) => new Point(-a.x, -a.y);

        // (a) Khoang cach
        public double TinhKhoangCach(Point b)
        {
            return Math.Sqrt(Math.Pow(b.x - this.x, 2) + Math.Pow(b.y - this.y, 2));
        }

        public static double TinhKhoangCach(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));
        }

        // (b) Trung diem
        public Point TimTrungDiem(Point b)
        {
            return new Point((this.x + b.x) / 2, (this.y + b.y) / 2);
        }

        public static Point TimTrungDiem(Point a, Point b)
        {
            return new Point((a.x + b.x) / 2, (a.y + b.y) / 2);
        }
    }
}