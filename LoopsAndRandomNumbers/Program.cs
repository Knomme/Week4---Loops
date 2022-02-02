using System;

namespace LoopsAndRandomNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			// Programm küsib kasutajal sisestada PIN-koodi;
			// Programm võrdelb sisestatud PIN-koodi arvuga 1234;
			// Kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
			// Kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti!";
			// Kasutajal on 3 katset;


			int i = 0; 

			while (i < 3) 
			{

				Console.WriteLine("Palun sisestage PIN-kood!");
				int pinKood = Convert.ToInt32(Console.ReadLine());


				if (pinKood == 1234)
				{
					Console.WriteLine("Tere tulemast!");
					break;
				}

				else
				{					
					i++;
					Console.WriteLine($"Vale PIN. {3 -i} katset on jäänud!");
				}

			}

			Console.WriteLine("Kena Päeva!");




		}
	}
}
