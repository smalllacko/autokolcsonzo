using System;

namespace autokolcsonzoo
{
	class Program
	{

		public static void Main(string[] args)
		{
			double egyenleg = 500000.0;
			double uzemanyagAr = 437.0; //  Ft/liter

			KolcsonozhetoAuto[] flotta = new KolcsonozhetoAuto[10];


			KolcsonozhetoAuto elsoAuto = new KolcsonozhetoAuto("ABC-123", "Suzuki", 1995, 4, 40, 5.7, 'A');
			KolcsonozhetoAuto masodikAuto = new KolcsonozhetoAuto("CBA-321", "Volvo", 2010, 8, 80, 5.7, 'A');
			KolcsonozhetoAuto harmadikAuto = new KolcsonozhetoAuto("BCA-231", "Chevrolet", 2021, 6, 60, 5.7, 'A');

			flotta[0] = elsoAuto;
			flotta[1] = masodikAuto;
			flotta[2] = harmadikAuto;
			flotta[3] = randomUjAuto();
			flotta[4] = randomUjAuto();

			for (int i = 0; i <= 4; i++)
			{
				Console.Write(flotta[i].getRendszam() + " ; ");
				Console.Write(flotta[i].getGyarto() + " ; ");
				Console.Write(flotta[i].getGyartasEve() + " ; ");
				Console.Write(flotta[i].getUtasSzam() + " ; ");
				Console.Write(flotta[i].getuzemanyagMennyiseg() + " ; ");
				Console.Write(flotta[i].getFogyasztas() + " ; ");
				Console.Write(flotta[i].getBerelheto() + " ; ");

				Console.WriteLine(flotta[i].getKategoria());

			}
			Console.ReadLine();
		}
		public static KolcsonozhetoAuto randomUjAuto()
		{
			Random gen = new Random();

			string[] gyartok = {
				"Maserati",
				"Jeep",
				"Volvo",
				"Suzuki",
				"Volvo",
				"Lada"
			};

			char[] abc = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
			string abcS = ("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
			string rszam = "";
			for (int i = 0; i < 3; i++)
			{
				rszam += abcS[gen.Next(0, abcS.Length)];

			}
			rszam += "-";
			for (int i = 0; i < 3; i++)
			{
				rszam += gen.Next(0, 10).ToString();

			}

			string marka = gyartok[gen.Next(0, gyartok.Length)];
			int ev = gen.Next(1995, 2022);
			int utasok = gen.Next(2, 10);
			int tartaly = gen.Next(20, 71);
			double lpkm = 5.5 + (11 * gen.NextDouble());
			char kat = abc[gen.Next(0, 3)];

			KolcsonozhetoAuto auto = new
				KolcsonozhetoAuto(rszam, marka, ev, utasok, tartaly, lpkm, kat);
			return auto;

		}




	}
}