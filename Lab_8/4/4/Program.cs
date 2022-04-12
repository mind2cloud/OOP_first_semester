using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Я давно заметил, sdasd, sdjk!";
		Console.WriteLine("Исходное предложение:  {0}", str);


		int slova = 0, znaki = 0;
		for(int i = 0; i < str.Length; i++)
		{
			if (str[i] == ' ') slova++;
			if (str[i] == ',' || str[i] == ';' || str[i] == '.' || str[i] == '!') znaki++;
		}

		Console.WriteLine("Общая сложность предложения = {0}", slova + 1 + znaki);
	}
} 