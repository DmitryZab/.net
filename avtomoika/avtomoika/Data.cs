using System;
using System.Collections.Generic;
using System.Text;

namespace avtomoika
{
    class Data
    {
        public List<Klient> DataKlient = new List<Klient>();
        List<Sotrydnic> DataSotrydnic = new List<Sotrydnic>();
        //Добавление клиента в базу
        public void InsertKlient(Klient a)
        {
            DataKlient.Add(a);
        }
        //Добывление Сотрудника в базу
        public void InsertSotrydnic(Sotrydnic a)
        {
            DataSotrydnic.Add(a);
        }
        //Кол-во посетителей за все время
        public void NumberOfPeople()
        {
            Console.WriteLine($"Все посетители");
            foreach(var i in DataKlient)
            {
                Console.WriteLine("----------------------------------");
                i.printFIO();
                Console.Write("Потратил  "); i.GetMoneySpent();
                Console.WriteLine($"Получил {i.ByuService}   услуг");
                Console.WriteLine("----------------------------------");
            }
        }
        public void AllEmployees()
        {
            Console.WriteLine($"Сотрудники");
            foreach(var i in DataSotrydnic)
            {
                Console.WriteLine("----------------------------------");
                i.printFIO();
                i.AllWork();
                Console.WriteLine("----------------------------------");
            }
        }

    }
}
