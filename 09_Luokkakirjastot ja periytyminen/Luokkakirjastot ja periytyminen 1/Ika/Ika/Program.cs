using Elain_Kirjasto;

for (int i = 0; i < 10; i++)
{
    kissa cat = new kissa();
    koira dog = new koira();
    Console.WriteLine("Koira on: " + dog.PalautaIka() + " vuotta, Kissa on: " + cat.PalautaIka() + " vuotta");
    if (cat.PalautaIka() > dog.PalautaIka())
    {
        Console.WriteLine("Kissa on vanhmepi");
    }
    else
    {
        Console.WriteLine("koira on vanhempi");
    }
    dog.Haukku();
    cat.Kehraa();
}