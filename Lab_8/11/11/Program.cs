using System;
class Program
{
		static bool sort(string a, string b)
		{
			int i = 0;
			while (i < a.Length && i < b.Length && a[i] == b[i])
				i++;
			if (i == a.Length && i < b.Length) return true;
			if (i < b.Length && a[i] < b[i]) return true;
			return false;
		}

		static void Main(string[] args)
		{
			string str = "Петров Иванов Сидоров Беляев Рутняковский Мусоргский Сечин Фомин Алексеев Носов Губчинский Достоевский";
			string[] str1 = str.Split(' ');

			for (int i = 0; i < str1.Length; i++)
			{
				for (int j = 0; j < str1.Length - 1; j++)
					if (sort(str1[j + 1], str1[j]))
					{
						string p = str1[j];
						str1[j] = str1[j + 1];
					str1[j + 1] = p;
					}
			}

		Console.WriteLine("-----------------------------------------------------------");
		Console.WriteLine("\t   Отсортированные фамилии по алфавиту");
		Console.WriteLine("-----------------------------------------------------------");
			for (int i = 0; i < str1.Length; i++)
				Console.WriteLine(str1[i]);
		}
}
