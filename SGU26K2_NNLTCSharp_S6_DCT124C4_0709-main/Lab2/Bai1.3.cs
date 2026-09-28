using System;

namespace Lab2
{
    public class Person
    {
        private string id;
        private string name;
        private int yob;
        private int yod;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Yob
        {
            get { return yob; }
            set { yob = value; }
        }

        public int Yod
        {
            get { return yod; }
            set { yod = value; }
        }

        public Person()
        {
            id = "";
            name = "";
            yob = 0;
            yod = 0;
        }

        public Person(string id, string name, int yob, int yod)
        {
            this.id = id;
            this.name = name;
            this.yob = yob;
            this.yod = yod;
        }

        public Person(string id, string name, int yob)
        {
            this.id = id;
            this.name = name;
            this.yob = yob;
            this.yod = 0;
        }

        public Person(Person p)
        {
            this.id = p.id;
            this.name = p.name;
            this.yob = p.yob;
            this.yod = p.yod;
        }

        public bool IsLiving()
        {
            return yod == 0;
        }

        public override string ToString()
        {
            string trangThai = IsLiving() ? "Còn sống" : "Đã mất (" + yod + ")";
            return "[" + id + "] " + name + " - Sinh năm: " + yob + " | Trạng thái: " + trangThai;
        }
    }

    public class Bai1_3
    {
        public static void Run()
        {
            Console.WriteLine("=== LAB 2 - BÀI 1.3: LỚP PERSON ===");
            Person p1 = new Person("P01", "Nguyen Van A", 1990);
            Person p2 = new Person("P02", "Tran Van B", 1920, 2005);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
        }
    }
}