using System;

namespace GuessingGameThreeTries
{
	class Program
	{
		static void Main(string[] args)
		{
			// Programm genereerib juhusliku numbrit 1-10;
			// Kasutaja peab selle numbri ära arvama;
			// Kui kasutaja suutis numbri ära arvata, siis on mängu võitnud;
			// Kasutajal on kolm katset, kui kastuaja pole suutnud kolme katsega arvata
			// siis mänugu võidab arvuti;
			// Programm genereerib juhusliku numbrit vaid üks kord;

			Random rnd = new Random();
			int cpuNumber = rnd.Next(1, 11);
			int i = 0;
			Console.WriteLine($"Palun arva ära juhuslik number 1-10ni!");
			

			while (i < 3)
			{				
				int userNumber = Convert.ToInt32(Console.ReadLine());

				if (cpuNumber == userNumber)
				{
					Console.WriteLine($"Palju õnne, Teie vastus nr {userNumber} on õige! :)");
					break;
				}

				else
				{
					i++;
					Console.WriteLine($"Teie vastus on vale, järelejäänud katsete arv: {3 - i}");
				}			

			}

			Console.WriteLine("Mäng on lõppenud, Kena päeva!!");



}	}	}

