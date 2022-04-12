using System;

class Competition
{
	public string famile;
}
class Competition1 : Competition
{
	public string society;
	public double[] x;
	public double sum;
	public Competition1(string famile1, string society, double[] x1)   // Одновременно инициализируем класс и считаем сумму
	{
		famile = famile1;
		this.society = society;
		x = x1;
		for (int i = 0; i < 2; i++)
			sum += x[i];
	}
}

class Program
{
	public static void Main(string[] args)
	{
		Competition1[] list = new Competition1[5];
		list[0] = new Competition1 ("Ivanov", "Gazprom", new double[] { 230.5, 250.9 });
		list[1] = new Competition1 ("Petrov", "ROSATOM", new double[] { 250.1, 294.7 });
		list[2] = new Competition1 ("Sidorov", "Roscosmos", new double[] { 190.0, 299.5 });
		list[3] = new Competition1 ("Mikhaiov", "UGMK", new double[] { 213.8, 274.5 });
		list[4] = new Competition1 ("Kirilov", "Yandex", new double[] { 277.8, 199.9 });

		for (int i = 0; i < list.Length; i++)
			Console.WriteLine("Surname: {0} \t Society: {2}  \t Average score: {1,4:f2}", list[i].famile, list[i].sum, list[i].society);

		for (int i = 0; i < list.Length - 1; i++)
		{
			double amax = list[i].sum;
			int imax = i;
			for (int j = i + 1; j < list.Length; j++)
			{
				if (list[j].sum > amax)
				{
					amax = list[j].sum;	
					imax = j;
				}
			}
			Competition1 p;
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
			Console.WriteLine("Place: {2}   Surname: {0} \t Society: {3} \t " + "Average score: {1,4:f1}", list[i].famile, list[i].sum, i + 1, list[i].society);
		}
	}
}
 