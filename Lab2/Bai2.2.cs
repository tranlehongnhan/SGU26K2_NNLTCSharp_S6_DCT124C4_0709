using System;
using System.Collections.Generic;

namespace Lab2
{
    public class PersonList
    {
        private List<Person> listPerson;

        public PersonList()
        {
            listPerson = new List<Person>();
        }

        public PersonList(PersonList pl)
        {
            listPerson = new List<Person>();
            for (int i = 0; i < pl.listPerson.Count; i++)
            {
                listPerson.Add(new Person(pl.listPerson[i]));
            }
        }

        public void Add(Person x)
        {
            listPerson.Add(x);
        }

        public PersonList LivingPeople()
        {
            PersonList res = new PersonList();
            for (int i = 0; i < listPerson.Count; i++)
            {
                if (listPerson[i].IsLiving())
                {
                    res.Add(listPerson[i]);
                }
            }
            return res;
        }

        public void Output()
        {
            for (int i = 0; i < listPerson.Count; i++)
            {
                Console.WriteLine(listPerson[i].ToString());
            }
        }
    }

    public class Bai2_2
    {
        public static void Run()
        {
            Console.WriteLine("=== LAB 2 - BÀI 2.2: LỚP PERSONLIST ===");
            PersonList pl = new PersonList();
            pl.Add(new Person("P01", "Nguyen Van A", 1990));
            pl.Add(new Person("P02", "Tran Van B", 1930, 2010));
            pl.Add(new Person("P03", "Le Thi C", 2000));

            Console.WriteLine("--- Danh sách toàn bộ nhân khẩu ---");
            pl.Output();

            Console.WriteLine("\n--- Danh sách những người còn sống ---");
            PersonList living = pl.LivingPeople();
            living.Output();
        }
    }
}