using System;
class Attestation
{
	public string famile;
	public double mark;
}
class Attestation1 : Attestation
{
	public double passlessons;
	public Attestation1(string famile, double mark, double passlessons)
	{
		this.famile = famile;
		this.mark = mark;
		this.passlessons = passlessons;
	}
}


class Program
{
	public static void Main(string[] args)
	{
		Attestation1[] list = new Attestation1[16];
		list[0] = new Attestation1("Ivanov", 5, 1);
		list[1] = new Attestation1("Petrov", 3, 6);
		list[2] = new Attestation1("Sidorov", 4, 0);
		list[3] = new Attestation1("Mikhailova", 0, 21);
		list[4] = new Attestation1("Mezencev", 2, 14);
		list[5] = new Attestation1("Kim", 3, 4);
		list[6] = new Attestation1("Sahno", 2, 10);
		list[7] = new Attestation1("Koshmetko", 2, 22);
		list[8] = new Attestation1("Ivanova", 5, 1);
		list[9] = new Attestation1("Mihalchak", 2, 16);
		list[10] = new Attestation1("Bakanova", 3, 7);
		list[11] = new Attestation1("Mamontov", 0, 17);
		list[12] = new Attestation1("Zayetcev", 2, 7);
		list[13] = new Attestation1("Vasilyeva", 2, 19);
		list[14] = new Attestation1("Rovin", 2, 4);
		list[15] = new Attestation1("Kolesnikova", 5, 0);

		for (int i = 0; i < list.Length; i++)
			Console.WriteLine("Surname: {0} \t Mark: {1} \t Пропусков: {2}", list[i].famile, list[i].mark, list[i].passlessons);

		for (int i = 0; i < list.Length - 1; i++)
		{
			if (list[i].mark == 2)
			{
				double amax = list[i].passlessons;
				int imax = i;
				for (int j = i + 1; j < list.Length; j++)
				{
					if (list[j].passlessons > amax)
					{
						amax = list[j].passlessons;
						imax = j;
					}
				}
				Attestation1 p;
				p = list[imax];
				list[imax] = list[i];
				list[i] = p;
			}
		}

		Console.WriteLine();

		Console.WriteLine("-----------------------------------------------------------------");
		Console.WriteLine("\t\t Таблица пропусков неуспевающих");
		Console.WriteLine("-----------------------------------------------------------------");
		for (int i = 0; i < list.Length; i++)
		{
			if (list[i].mark == 2) Console.WriteLine("Surname: {0} \t  Пропусков: {1}", list[i].famile, list[i].passlessons);
		}
	}
}