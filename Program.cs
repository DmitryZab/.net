using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] inMonthsDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			short month = 0;

			Console.Write("Введите свой имя:  ");
			string name = Console.ReadLine();
			Console.Write($"Привет {name}") ;
			Console.WriteLine();


			Console.Write("Введите кол-во прожитых дней:  ");
			string tempDay = Console.ReadLine();

			int year = (Convert.ToInt32(tempDay) / 365);
			int day = (Convert.ToInt32(tempDay) % 365);

			while(day - inMonthsDays[month] >0)
			{
					day -= inMonthsDays[month];
					month++;
			}
			Console.Write($"Прожито {year} лет {month} месяцев {day} дней");
			Console.ReadKey();
		}
	}
}
