using System;

class Program
{
	static string Encoding(string str)    //метод шифровки или дешифровки текста
	{
		string[] str1 = str.Split(' ');
		for (int i = 0; i < str1.Length; i++)
		{
			char[] ch = str1[i].ToCharArray();
			for (int j = 0; j < str1[i].Length / 2; j++)
			{
				char p;
				p = ch[j];
				ch[j] = ch[ch.Length - 1 - j];
				ch[ch.Length - 1 - j] = p;
			}
			str1[i] = new string(ch);
		}
		str = string.Join(" ", str1);
		return str;
	}

	static void Main(string[] args)
	{
			Console.WriteLine("-------------------------------------------------------------------------------------------");
			Console.WriteLine("\t\t\t\t Исходные данные");
			Console.WriteLine("-------------------------------------------------------------------------------------------");

			string str_desh = "Сегодня хорошая погода! В понедельник генеральный директор «Татнефти» Наиль Маганов заявил, что в 2017 году компания сократит добычу нефти!";
			Console.WriteLine("Исходное сообщение (нбхд зашифровать):\t {0}", str_desh);
			string str_sh = "!инд еишйажилб в тюутратс ижадорП";
			Console.WriteLine("Исходное сообщение (нбхд расшифровать):\t {0}", str_sh);

			Console.WriteLine("-------------------------------------------------------------------------------------------");
			Console.WriteLine("\t\t\t Шифровка или дешифровка сообщения");
			Console.WriteLine("-------------------------------------------------------------------------------------------");

			Console.WriteLine("Зашифрованное сообщение:\t {0}", Encoding(str_desh));
		Console.WriteLine("Дешифрованное сообщение:\t {0}", Encoding(str_sh));
	}

		
}
