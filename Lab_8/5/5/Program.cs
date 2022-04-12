using System;
class Program
{
		static void Main(string[] args)
		{
			string str = "Нам дана возможность выбора, но не дано возможности избежать выбора.";
			Console.WriteLine("Исходное предложение: {0}", str);

			
			char[] arr = new char[str.Length]; 								// Массив из первых букв слов текста
			arr[0] = str[0];
			int[] count = new int[str.Length];
			count[0] = 1;
			int k = 1;

			for (int i = 1; i < str.Length - 1; i++)
				if (str[i] == ' ')  										// Находим пробел
				{
					bool b = false;
					for (int j = 0; j < k; j++) 							// Считаем первую букву слоа
						if (str[i + 1] == arr[j])
						{
							b = true;
							count[j]++;
						}
				if (b == false) 											// Если буква не записана
					{
						arr[k] = str[i + 1];
						count[k]++;
						k++;
					}
				}
			
			for (int i = 0; i < count.Length - 1; i++) 						// Сортировка по убыванию
			{
				int max = count[i],
					imax = i;
				for (int j = i + 1; j < count.Length; j++)
					if (count[j] > max)
					{
						max = count[j];
						imax = j;
					}
				int p;
				p= count[imax];
				count[imax] = count[i];
				count[i] = p;
				char p1;
				p1 = arr[imax];
				arr[imax] = arr[i];
				arr[i] = p1;
			}

			Console.WriteLine("-----------------------------------------------------------------------");
			Console.WriteLine("\tВывод первых букв слов по убыванию частоты встречаемости:");
			Console.WriteLine("-----------------------------------------------------------------------");
			for (int i = 0; i < arr.Length; i++)
				if (count[i] != 0 && arr[i] != ' ')
					Console.WriteLine("Место: {2} Буква: {0}  частота: {1}", arr[i], count[i], i + 1);
		}
}
