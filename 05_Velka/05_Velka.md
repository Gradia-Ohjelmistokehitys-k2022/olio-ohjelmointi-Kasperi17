# Velka

Luo uusi projekti tai käytä annettua projektia.

Kiinnitä huomiota tehtävänannon täsmällisiin muuttujien- ja kenttien nimiin.

1. Luo projektiin luokka Velka, jolla on double-tyyppiset oliomuuttujat _saldo ja _korkoProsentti.
2. Saldo ja korkoProsentti annetaan konstruktorin parametrina public Velka(double saldoAlussa, double korkoProsentti).
3. Luo luokalle myös metodit public void TulostaSaldo() sekä public void OdotaVuosi(). Metodi TulostaSaldo tulostaa tämän hetkisen saldon, ja metodi OdotaVuosi kasvattaa velan määrää.

Velan määrän kasvattaminen tapahtuu kertomalla saldo korkoprosentilla. (_saldo=_saldo * (1+_korkoProsentti)

esim. _saldo = 100*(1+0,05)=105

