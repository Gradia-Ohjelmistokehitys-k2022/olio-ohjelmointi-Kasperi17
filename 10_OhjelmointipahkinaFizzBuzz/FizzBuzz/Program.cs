using Elain_Kirjasto;
using Eläin_Kirjasto;
 static string GenerateName(int len)
{
    Random r = new Random();
    string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
    string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
    string Name = "";
    Name += consonants[r.Next(consonants.Length)].ToUpper();
    Name += vowels[r.Next(vowels.Length)];
    int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
    while (b < len)
    {
        Name += consonants[r.Next(consonants.Length)];
        b++;
        Name += vowels[r.Next(vowels.Length)];
        b++;
    }

    return Name;


}
Random random = new Random();

Console.WriteLine("montako eläin luodaan");
int luku = int.Parse(Console.ReadLine());
List<Elain> elista = new List<Elain>();


for (int i = 0; i <= luku; i++)
{

    if (i % 3 == 0)
    {
        Elain e;
        e = new kissa();
        e.AsetaNimi(GenerateName(10));
        e.AsetaIka(random.Next(1, 50));
        e.tasalampoinen();
        elista.Add(e);
    }

    else if (i % 3 == 1)
    {
        Elain e;
        e = new koira();
        e.AsetaNimi(GenerateName(4));
        e.AsetaIka(random.Next(1, 50));
        e.tasalampoinen();
        elista.Add(e);
    }

    else 
    {
        Elain e;
        e = new Papukaija();
        e.AsetaNimi(GenerateName(30));
        e.AsetaIka(random.Next(1, 50));
        e.Muniiko();
        elista.Add(e);
    }
}

List<Elain> el = new List<Elain>();

int j = 0;
foreach (Elain elain in elista)
{

    j++;
    if (j % 4 == 0) //joka neljäs korvataan hevosella
    {
        Elain e;
        e = new Hevonen();
        e.AsetaNimi(GenerateName(10));
        e.AsetaIka(random.Next(1, 50));
        e.tasalampoinen();
        el.Add(e);
        continue;
    }
    el.Add(elain);
}
foreach (Elain elain in el)

{
    Console.WriteLine("Elaimen tyyppi on {0}", elain.GetType());
    Console.WriteLine("Elaimen nimi on {0}", elain.PalautaNimi());
    Console.WriteLine("Elaimen ika on {0}", elain.PalautaIka());
    Console.WriteLine("Syoko elain lihaa {0}", elain.lihansyoja());
    Console.WriteLine("Muniiko elain {0}", elain.Muniiko());
    Console.WriteLine("Onko elain tasolampoinen{0}  " , elain.tasalampoinen());
    Console.WriteLine("Onko elain Lamminverinen {0} " , elain.lamminverinen());
}

