using System;

namespace avtomoika
{
    class Program
    {
        static void Main(string[] args)
        {
            Data BigData = new Data();
            Klient[] clientBase = { new Klient("Заболотских Дмитрий Алексеевич", 18, 20000, "boy"), 
                new Klient("Третьякова Анастасия Алексеевна", 29, 10000, "girl")
        };
            /*Klient Nastua = new Klient("Третьякова Анастасия Алексеевна", 29, 10000, "girl");*/
            Sotrydnic Oleg = new Sotrydnic("Алексеев Олег Иванович");
            Sotrydnic Roma = new Sotrydnic("Воронцов Роман Русланович");
            Yslugi Xim = new Yslugi("Химчистка салона", 1000);
            Yslugi Carwash = new Yslugi("Мойка автомобиля", 5000);
            clientBase[0].Servies(Xim, Oleg);
            clientBase[0].Servies(Carwash, Roma);
            clientBase[1].Servies(Xim, Oleg);
            /*BigData.InsertKlient(clientBase[0]);
            BigData.InsertKlient(clientBase[1]);*/
            BigData.InsertSotrydnic(Roma);
            BigData.InsertSotrydnic(Oleg);
            Array.Sort(clientBase);
            /*BigData.NumberOfPeople();*/
            Console.WriteLine("Полетители:");
            foreach(var i in clientBase)
            {
                i.printFIO();
                Console.WriteLine($"Потратил {i.moneySpent}, получил услуг {i.ByuService}");
            }
            BigData.AllEmployees();

        }
    }
}
