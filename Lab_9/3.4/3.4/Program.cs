using System;
using System.Text;
using System.IO;
struct Group1
{
	public string famile;
	public double rezult;
	public Group1(string famile, double rezult1)   // Инициализируем структуру групп
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
	{                                                                                           //двух упорядоченных массивов
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
		Group1[] lists = new Group1[m];

		string line1;                                                                //Считывание из файла
		string path1 = "Competition_list_1.txt";
		StreamReader sr1 = new StreamReader(path1, Encoding.GetEncoding(1252));
		int y = 0;
		while ((line1 = sr1.ReadLine()) != null)
		{
			
			string[] sports = line1.Split(' ');
			listf[y].famile = sports[0];
			listf[y].rezult = double.Parse(sports[1]);
			y++;
		}
		sr1.Close();

		string line2;
		string path2 = "Competition_list_2.txt";
		StreamReader sr2 = new StreamReader(path2, Encoding.GetEncoding(1252));
		y = 0;
		while ((line2 = sr2.ReadLine()) != null)
		{

			string[] sports = line2.Split(' ');
			lists[y].famile = sports[0];
			lists[y].rezult = double.Parse(sports[1]);
			y++;
		}
		sr2.Close();

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
		Sort_Total(listf, lists, listr, n, m);

		Console.WriteLine("-----------------------------------------------------------------------------");
		Console.WriteLine("\t Итоговая таблица результатов двух групп в порядке занятых мест:");
		Console.WriteLine("-----------------------------------------------------------------------------");
		for (int i = 0; i < listr.Length; i++)
		{
			Console.WriteLine("Place: {2} Surname: {0}\t Rezult: {1}", listr[i].famile, listr[i].rezult, i + 1);
		}

		string path3 = "Competition_list_Total.txt";         //Запись в файл 
		StreamWriter sr3 = new StreamWriter(path3);
		sr3.WriteLine("-----------------------------------------------------------------------------");
		sr3.WriteLine("\t Итоговая таблица результатов двух групп в порядке занятых мест:");
		sr3.WriteLine("-----------------------------------------------------------------------------");
		for (int i = 0; i < listr.Length; i++)
		{
			sr3.WriteLine("Место: {2} Фамилия: {0}\t Результат: {1}", listr[i].famile, listr[i].rezult, i + 1);
		}
		sr3.Close();
	}
}
