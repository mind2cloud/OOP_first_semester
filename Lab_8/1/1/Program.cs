using System;
	class Program
	{
		static void Main(string[] args)
		{
			const int n = 34;

			int kol = 0; //Общее количество символов
			char[] letters = new char[n] { 'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', '.', '!' };
			double[] counter = new double[n];  //Массив для подсчета

		string str = "Роджер утверждает, что мы не существуем. Как раз наоборот, только мы и существуем! Они тени, мы вкладываем в них телесное содержание. Мы — символы всей этой беспорядочной, бесцельной борьбы, которая называется жизнью, а только символ реален. Говорят: игра — притворство. Это притворство и есть единственная реальность. (С. Моэм - Театр)";

			Console.WriteLine("Строка: {0}", str);

			string str1 = str.ToLower();  //Все буквы в нижний регистр

			for (int i = 0; i < str1.Length; i++)
				for (int j = 0; j < n; j++)
				{
					if (str1[i] == letters[j])
					{
						kol++;
						counter[j]++;
						break;
					}
				}

			for (int i = 0; i < n; i++)    				//Подсчет частоты
				counter[i] = counter[i] / kol * 100;

			for (int i = 0; i < n - 1; i++)    			//Сортировка по убыванию
			{
				double max = counter[i];
				int imax = i;
				for (int j = i + 1; j < n; j++)
					if (counter[j] > max)
					{
						max = counter[j];
						imax = j;
					}
				double p;
				p = counter[imax];
				counter[imax] = counter[i];
				counter[i] = p;

				char p1;
				p1 = letters[imax];
				letters[imax] = letters[i];
				letters[i] = p1;
			}
		Console.WriteLine("--------------------------------------------------------------------------------");
			Console.WriteLine("\t Частота появления в строке букв русского алфавита (по убыванию):");
		Console.WriteLine("--------------------------------------------------------------------------------");
			for (int i = 0; i < n; i++)
				Console.WriteLine("{0}:\t Буква: {1} \t Частота: {2:f2}", i + 1, letters[i], counter[i]);
		}
	}

