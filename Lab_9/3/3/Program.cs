using System;
using System.Text;
using System.IO;
class Program
{
	static void Main(string[] args)
	{
			StreamReader sr = new StreamReader("Input.txt", Encoding.GetEncoding(1251));
			string str = sr.ReadLine();
			string[] str1 = str.Split(' ');
			int dlina = 0;
			sr.Close();

			Console.WriteLine("-----------------------------------------------");
			Console.WriteLine("\tСтроки не более чем в 50 символов");
			Console.WriteLine("-----------------------------------------------");

			StreamWriter sw = new StreamWriter("Output.txt");
			for (int i = 0; i < str1.Length; i++)
				{
					if (i != 0)
						dlina++;
					dlina+= str1[i].Length;

					if (dlina > 50)
					{
						Console.WriteLine();  //Переход на новую строку 
						sw.WriteLine(); 
					dlina = str1[i].Length;
					}
				Console.Write("{0} ", str1[i]);
				sw.Write("{0} ", str1[i]);
				}

		sw.Close();
	}
}

