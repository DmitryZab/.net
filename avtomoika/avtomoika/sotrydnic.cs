using System;
using System.Collections.Generic;
using System.Text;

namespace avtomoika
{
    class Sotrydnic
    {
        public Sotrydnic(string fio)
        {
            FIO = fio;
        }
        //public int job = 0;//кол-во работы которой выполнил сотрудник
        public string name;
        public string surname;
        public string patrnymic;
        private List<Yslugi> job = new List<Yslugi>();
        public string FIO { get; set; }
        public void ConvertFIO()
        {
            string[] value = FIO.Split(' ');
            name = value[1];
            surname = value[0];
            patrnymic = value[2];
        }
        public void printFIO()
        {
            ConvertFIO();
                Console.WriteLine($"Сотрудник  {surname} {name} {patrnymic}");
        }
        

        public void InsertJob(Yslugi a)
        {
            job.Add(a);
        }
        public void AllWork()
        {
            ConvertFIO();
            Console.WriteLine($" Выполнил: ");
            foreach(var i in job)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine();
        }
    }
}
