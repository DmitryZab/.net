using System;
using System.Collections.Generic;
using System.Text;

namespace avtomoika
{
    class Klient : IComparable
    {
        public Klient(string fio,int age,int balance,string sex)
        {
            Balance = balance;
            FIO = fio;
            Age = age;
            Sex = sex; 
        }
        private string name;
        private string surname;
        private string patrnymic;
        private string sex;
        public int moneySpent = 0;
        public int ByuService = 0;
        public string Sex { 
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            } 
        }
        public int Balance { get; set; }
        public int Age { get; set; }
        public string FIO { get;set; }
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
            if (sex == "boy")
            {
                Console.WriteLine($"Уважаемый {surname} {name} {patrnymic}");
            }
            else
            {
                Console.WriteLine($"Уважаемая {surname} {name} {patrnymic}");
            }
        }

       public void Servies(Yslugi a, Sotrydnic b)
        {
            if(Balance >= a.Price)
            {
                Balance -= a.Price;
                moneySpent += a.Price;
                b.InsertJob(a);
                ByuService ++;
            }
            else
            {
                Console.WriteLine("Недостаточно денег");
            }
             
        }

        public void GetMoneySpent()
        {
            Console.WriteLine(moneySpent);
        }

        public int CompareTo(object Klient2)
        {
            Klient client3 = (Klient)Klient2;
            if (this.ByuService > client3.ByuService)
            {
                return -1;
            }
            else if (this.ByuService == client3.ByuService)
            {
                if (this.Age > client3.Age)
                {
                    return -1;
                }
                else if (this.Age == client3.Age)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 1;
            }
        }
    }
}
