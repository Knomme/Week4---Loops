using System;

namespace GuessingGameInfinite
{
	class Program
	{
		static void Main(string[] args)
		{
			

			// Programm genereerib juhusliku numbrit 1-10;
			// Kasutaja peab selle numbri ära arvama;
			// Kui kasutaja suutis numbri ära arvata, siis on mängu võitnud;
			// Katsete arv on piiramatu;
			// Programm genereerib juhusliku numbrit vaid üks kord;


			Random rnd = new Random();
			int cpuNumber = rnd.Next(1, 11);
			
			Console.WriteLine("Palun arva ära juhuslik number 1-10ni");

			bool aktiivneL = true;

			while (aktiivneL)
			{				
				int userNumber = Convert.ToInt32(Console.ReadLine());

				if (cpuNumber == userNumber)
				{
					Console.WriteLine($"Palju õnne, Teie vastus nr {userNumber} on õige! :)");
					break;
				}

				else
				{
					
					Console.WriteLine($"Teie vastus on vale, proovi uuesti! ");
				}			

			}

			Console.WriteLine("Mäng on lõppenud, Kena päeva!!");






		}
	}
}
