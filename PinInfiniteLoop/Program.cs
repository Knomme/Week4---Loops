using System;

namespace PinInfiniteLoop
{
	class Program
	{
		static void Main(string[] args)
		{

			// Programm küsib kasutajal sisestada PIN-koodi;
			// Programm võrdelb sisestatud PIN-koodi aruvga 1234;
			// Kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
			// Kui sisestatud PiN-kood on midagi muud, siis konsool kuvab "Vale PIN, proovi uuesti!";
			// Katsete arv in piiramatu;


			bool loopActive = true; // Boolean - mudel milles on 2 väärtust ture/false
			int i = 0;


			while (loopActive)


			{
				Console.WriteLine("Sisesta PIN-kood!");
				int pinKood = Convert.ToInt32(Console.ReadLine());

				if (pinKood == 1234)
				{
					Console.WriteLine("Tere tulemast!");
					loopActive = false;
				}

				else
				{
					i++;
					Console.WriteLine("Vale PIN, proovi uuesti!");
					Console.WriteLine($"Oled vale PIN-koodi {i} sisestanud!");
				}


			}

			Console.WriteLine("Kena Päeva!");

		}
	}
}
