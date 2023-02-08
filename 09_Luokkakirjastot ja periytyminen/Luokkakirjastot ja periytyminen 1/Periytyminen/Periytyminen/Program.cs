using System.Collections.Generic;
using Elain_Kirjasto;
using Eläin_Kirjasto;

koira koira2 = new koira();
koira2.AsetaNimi("Perttu");
koira2.AsetaIka(7);
koira2.Asetalihansyoja();
Console.WriteLine("nimi on " + koira2.PalautaNimi() + " ja hän on " + koira2.PalautaIka() + " vuotias ja syö lihaa " + koira2.PalautaOnlihansyoja());
koira2.Haukku();



//7.Luo uusi Kissa-olio
kissa kissa2 = new kissa();

//Aseta sille nimi (käytä metodia: AsetaNimi)
kissa2.AsetaNimi("Haisuli");

//Aseta sille ikä (käytä metodia: AsetaIka)
kissa2.AsetaIka(13);

//Aseta onko lihansyöjä vai ei (true vai false)
kissa2.Asetalihansyoja();

//Tulosta kissan nimi ja ikä ja onko lihansyöjä käyttämällä PalautaNimi()-, PalautaIka() - ja PalautaOnLihanSyoja() - funktioita
Console.WriteLine("nimi on " + kissa2.PalautaNimi() + " ja hän on " + kissa2.PalautaIka() + " vuotias ja syö lihaa " + kissa2.PalautaOnlihansyoja());

//käske kissan kehrätä.
kissa2.Kehraa();

//8. Luo uusi Koira-olio
//Aseta sille nimi

//Aseta sille ikä

//Aseta onko lihansyöjä vai ei (true vai false)

//Tulosta koiran nimi ja ikä ja onko lihansyöjä käyttämällä PalautaNimi()-, PalautaIka() - ja PalautaOnLihanSyoja() - funktioita.Koiralla ei pitäisi näkyä Kehrää() metodia.
Papukaija papukaija2 = new Papukaija();
Hevonen hevonen2 = new Hevonen();
koira2.Aantele();
papukaija2.Aantele();
hevonen2.Aantele();
Console.WriteLine("Muniiko koira munan " + koira2.Muniiko());
Console.WriteLine("Muniiko papukaija munan " + papukaija2.Muniiko());
Console.WriteLine("onko koira tasalämpöinen" + koira2.tasalampoinen());
Console.WriteLine("onko papakaija tasalämpöinen" + papukaija2.tasalampoinen());

