using System;
class SportJump
{
	public string famile;
	public double[] mark;
	public double Summary;
}

class SportJump1: SportJump
{
	public double distance;
	public SportJump1(string famile, double[] mark1, double distance)
	{
		this.distance = distance;
		this.famile = famile;
		mark = mark1;

		double amax = -1, amin = 100;                                   //Выполняем условия задачи
		int imax = 0, imin = 0;
		for (int i = 0; i < 5; i++)
		{
			if (mark1[i] > amax)
			{
				amax = mark1[i];
				imax = i;
			}
			if (mark1[i] < amin)
			{
				amin = mark1[i];
				imin = i;
			}
		}
		mark1[imax] = 0;
		mark1[imin] = 0;
		for (int i = 0; i < 5; i++)                                     //Находим сумму оценок судей без мах и мин
		{
			Summary += mark1[i];
		}
	}
}

class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("-----------------------------------------------------------------");
		Console.WriteLine("\t\t\t Протокол соревнований");
		Console.WriteLine("-----------------------------------------------------------------");

		SportJump1[] list = new SportJump1[7];
		list[0] = new SportJump1("Ivanov", new double[] { 11, 17, 18, 14, 15 }, 117);
		list[1] = new SportJump1("Petrov", new double[] { 17, 17, 18, 17, 16 }, 121);
		list[2] = new SportJump1("Sidorova", new double[] { 14, 19, 20, 17, 18 }, 125);
		list[3] = new SportJump1("Mikhaiova", new double[] { 12, 13, 12, 11.0, 15 }, 110);
		list[4] = new SportJump1("Mezencev", new double[] { 19, 19, 19, 15, 19 }, 123);
		list[5] = new SportJump1("Kim", new double[] { 15, 15, 14, 16, 11 }, 129);
		list[6] = new SportJump1("Sahno", new double[] { 16, 18, 17, 17, 18 }, 123);


		for (int i = 0; i < list.Length; i++)
		{
			Console.Write("Surname: {0} \t Mark: ", list[i].famile);            //Выводим введенные данные
			for (int j = 0; j < 5; j++)
				Console.Write("{0} ", list[i].mark[j]);
			Console.WriteLine("Distance: {0}", list[i].distance);
		}

		for (int i = 0; i < list.Length; i++)
		{
			if (list[i].distance == 120)
				list[i].Summary += 60;
			else if (list[i].distance > 120)
				list[i].Summary += (list[i].distance - 120) * 2;
			else if (list[i].distance < 120)	list[i].Summary -= (120 - list[i].distance) * 2;
		}

		for (int i = 0; i < list.Length - 1; i++)   //Сортируем итоговую сумму баллов по убыванию
		{
				double amax = list[i].Summary; 
				int imax = i;
				for (int j = i + 1; j < list.Length; j++)
				{
					if (list[j].Summary > amax)
					{
						amax = list[j].Summary;
						imax = j;
					}
				}
				SportJump1 p;
				p = list[imax];
				list[imax] = list[i];
				list[i] = p;
		}

		Console.WriteLine();

		Console.WriteLine("-----------------------------------------------------------------");
		Console.WriteLine("\t\t\t Таблица результатов");
		Console.WriteLine("-----------------------------------------------------------------");
		for (int i = 0; i < list.Length; i++)
		{
			Console.WriteLine("Место: {2} \t Surname: {0} \t  Суммарный балл: {1:f2}", list[i].famile, list[i].Summary, i + 1);
		}
	}
}
