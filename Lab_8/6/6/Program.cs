using System;
class Program
{
	static void Main(string[] args)
        {
        string str = "Доброе утро, мистер Олдман"; //исходная строка
		int[] count = new int[10];
		char[] glasnie = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };

		Console.WriteLine("Исходная строка: {0}", str);

		string[] slovo = str.Split(' ');

		for (int i = 0; i < slovo.Length; i++)
		{
			int kol = 0;
			for (int j = 0; j < slovo[i].Length; j++)
				for (int k = 0; k < glasnie.Length; k++)
					if (slovo[i][j] == glasnie[k])
					{
						kol++;
						break;
					}
			count[kol - 1]++;
		}

		for (int i = 0; i < count.Length; i++)
			if (count[i] != 0)
				Console.WriteLine("Число слогов: {0}  Количество слов: {1}", i + 1, count[i]);
   }
}