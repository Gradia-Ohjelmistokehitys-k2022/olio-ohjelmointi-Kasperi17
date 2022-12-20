using System;
using System.Security.Cryptography.X509Certificates;

public class kissa
{
	private int ika;
	public string Nimi;

	public kissa()
	{
		this.ika = 10;
		Nimi = "Pekka";
	}



	public kissa(int ika, string nimi)
	{
		this.ika = ika;
		this.Nimi = nimi;

	}


	public int PalautaKissanIka()
	{
		return ika;
	}
	public bool AsetakissanIka(int age)
	{
		if (age < 0)
		{
			Console.WriteLine("väärä ikä");
			return false;
		}


		else
		{
			ika = age;
			return true;
		}
	}

	public bool AsetaKissanNimi(string Uusinimi)
	{
		string pienennetty = Uusinimi.ToUpper();
		if (pienennetty != "HILDA")

		{
			Nimi = Nimi;
			return true;

		}
		else
		{
			Nimi = Uusinimi;
			return false;
		}




	}

	public override string ToString()
	{
		return "kissan nimi on " + Nimi  + " ja ikä on " + ika;
	}







}
