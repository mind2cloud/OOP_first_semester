using System;

	class Program
	{
		static void Main(string[] args)
		{
			string str = "Что такое официальное лицо или неофициальное? Всё это зависит от того, с какой точки зрения смотреть на предмет, всё это, Никанор Иванович, условно и зыбко. Сегодня я неофициальное лицо, а завтра, глядишь, официальное! А бывает и наоборот, Никанор Иванович. И ещё как бывает!";
			int dlina = 0;
			string[] str1 = str.Split(' ');

			Console.WriteLine("-----------------------------------------------");
			Console.WriteLine("\tСтроки не более чем в 50 символов");
			Console.WriteLine("-----------------------------------------------");

			for (int i = 0; i < str1.Length; i++)
				{
					if (i != 0)
						dlina++;
					dlina+= str1[i].Length;

					if (dlina > 50)
					{
						Console.WriteLine();  //Переход на новую строку 
					dlina = str1[i].Length;
					}
				Console.Write("{0} ", str1[i]);
				}
			}
}

