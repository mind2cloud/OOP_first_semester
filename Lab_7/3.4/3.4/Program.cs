using System;
public class Group
{ 
	public string famile;
}
public class Group1: Group
{
	public double rezult;
	public Group1(string famile, double rezult1)
	{
		this.famile = famile;
		rezult = rezult1;
	}
}

class Program
{
	public static void Sort_max(Group1[] note)      // Метод сортировки по убыванию результатов
	{
		for (int j = 0; j < note.Length; j++)
		{
			for (int i = 0; i < note.Length - 1; i++)
			{
				if (note[i].rezult < note[i + 1].rezult)
				{
					Group1 p = note[i];
					note[i] = note[i + 1];
					note[i + 1] = p;
				}
			}
		}
	}

	public static void Sort_Total(Group1[] listf, Group1[] lists, Group1[] listr, int m, int n) //Метод объединения
	{																							//двух упорядоченных массивов
																								//в один с сохранением упорядоченности
		int poka1 = 0, poka2 = 0, k = 0;
		while (poka1 < n && poka1 < m)
		{
			while (poka1 < n && poka2 < m && listf[poka1].rezult > lists[poka2].rezult)
			{
				listr[k] = listf[poka1];
				poka1++;
				k++;
			}
			while (poka2 < m && poka1 < n && lists[poka2].rezult >= listf[poka1].rezult)
			{
				listr[k] = lists[poka2];
				poka2++;
				k++;
			}
		}
		if (poka1 == n && poka2 != m)
			for (int w = k; w < n + m; w++)
			{
				listr[w] = lists[poka2];
				poka2++;
			}
		if (poka2 == m && poka1 != n)
			for (int w = k; w < n + m; w++)
			{
				listr[w] = listf[poka1];
				poka1++;
			}
	}

	public static void Main(string[] args)
	{
		int n = 7, m = 7;
		Group1[] listf = new Group1[n];
		listf[0] = new Group1("Ivanova", 130.5);
		listf[1] = new Group1("Petrova", 104.7);
		listf[2] = new Group1("Sidorova", 90.0);
		listf[3] = new Group1("Mikhaiova", 101.5);
		listf[4] = new Group1("Kirilova", 110.9);
		listf[5] = new Group1("Yakovlev", 121.5);
		listf[6] = new Group1("Demidov", 119.9);

		Group1[] lists = new Group1[m];
		lists[0] = new Group1("Shipulin", 140.5);
		lists[1] = new Group1("Lavrov", 114.1);
		lists[2] = new Group1("Kalinichenko", 155.2);
		lists[3] = new Group1("Bakanov", 13.9);
		lists[4] = new Group1("Nevsky", 122.3);
		lists[5] = new Group1("Lanskih", 135.0);
		lists[6] = new Group1("Durov", 130.1);

		Console.WriteLine("-----------------------------------------------------------------------------");
		Console.WriteLine("\t\t Протокол результатов первой группы:");
		Console.WriteLine("-----------------------------------------------------------------------------");
		for (int i = 0; i < listf.Length; i++)
			Console.WriteLine("Surname: {0}  \t Rezult: {1}", listf[i].famile, listf[i].rezult);
		Console.WriteLine("-----------------------------------------------------------------------------");
		Console.WriteLine("\t\t Протокол результатов второй группы:");
		Console.WriteLine("-----------------------------------------------------------------------------");
		for (int i = 0; i < lists.Length; i++)
			Console.WriteLine("Surname: {0}  \t Rezult: {1}", lists[i].famile, lists[i].rezult);

		Sort_max(listf);
		Sort_max(lists);

		Console.WriteLine("-----------------------------------------------------------------------------");
		Console.WriteLine("\t Таблица результатов первой группы в порядке занятых мест:");
		Console.WriteLine("-----------------------------------------------------------------------------");
		for (int i = 0; i < listf.Length; i++)
		{
			Console.WriteLine("Place: {2} Surname: {0}\t Rezult: {1}", listf[i].famile, listf[i].rezult, i + 1);
		}

		Console.WriteLine("-----------------------------------------------------------------------------");
		Console.WriteLine("\t Таблица результатов второй группы в порядке занятых мест:");
		Console.WriteLine("-----------------------------------------------------------------------------"); 
		for (int i = 0; i < lists.Length; i++)
		{
			Console.WriteLine("Place: {2} Surname: {0}\t Rezult: {1}", lists[i].famile, lists[i].rezult, i + 1);
		}

		Group1[] listr = new Group1[n + m];
		Sort_Total(listf, lists, listr, m, n);  //Вызов метода объединения двух упорядоченных массивов в один с сохранением упорядоченности

		Console.WriteLine("-----------------------------------------------------------------------------");
		Console.WriteLine("\t Итоговая таблица результатов двух групп в порядке занятых мест:");
		Console.WriteLine("-----------------------------------------------------------------------------");
		for (int i = 0; i < listr.Length; i++)
		{
			Console.WriteLine("Place: {2} Surname: {0}\t Rezult: {1}", listr[i].famile, listr[i].rezult, i + 1);
		}
	}
}