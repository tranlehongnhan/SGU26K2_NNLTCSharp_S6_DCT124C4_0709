using System;
using System.Collections.Generic;

namespace Lab2
{
    public class ArrayPoint
    {
        private List<Point> listPoint;

        public ArrayPoint()
        {
            listPoint = new List<Point>();
        }

        public ArrayPoint(int capacity)
        {
            listPoint = new List<Point>(capacity);
        }

        // Indexer
        public Point this[int index]
        {
            get
            {
                if (index >= 0 && index < listPoint.Count)
                    return listPoint[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < listPoint.Count)
                    listPoint[index] = value;
            }
        }

        public void Add(Point p)
        {
            listPoint.Add(p);
        }

        public int Count
        {
            get { return listPoint.Count; }
        }

        public void Output()
        {
            for (int i = 0; i < listPoint.Count; i++)
            {
                Console.WriteLine("Point[" + i + "] = " + listPoint[i].ToString());
            }
        }
    }

    public class Bai2_1
    {
        public static void Run()
        {
            Console.WriteLine("=== LAB 2 - BÀI 2.1: LỚP ARRAYPOINT ===");
            ArrayPoint ap = new ArrayPoint();
            ap.Add(new Point(1, 2));
            ap.Add(new Point(3, 4));
            ap.Add(new Point(5, 6));

            Console.WriteLine("Danh sách các điểm:");
            ap.Output();

            Console.WriteLine("\nTruy cập qua Indexer [1]: " + ap[1].ToString());
        }
    }
}