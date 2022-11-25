// See https://aka.ms/new-console-template for more information
using Geometria;

int baseUtente, hUtente, perimetro, area, i;
baseUtente = 0; hUtente= 0;

//RETTANGOLO 1

i = 1;
Console.WriteLine("Inserisci in ordine base ed altezza del rettagolo " + i + ".");
baseUtente = int.Parse(Console.ReadLine());
hUtente = int.Parse(Console.ReadLine());        //Valori in input

Rettangolo rettangolo1 = new Rettangolo();       //Istanza nuovo oggetto

rettangolo1.baseRettangolo = baseUtente;        //Attribuzione di valori alle proprietè dell'oggetto
rettangolo1.altezzaRettangolo = hUtente;

//Richiamo metodi area e perimetro da classe Rettangolo
area = rettangolo1.CalcolaArea(rettangolo1.baseRettangolo, rettangolo1.altezzaRettangolo);
perimetro = rettangolo1.CalcolaPerimetro(rettangolo1.baseRettangolo, rettangolo1.altezzaRettangolo);

rettangolo1.StampaRettangolo(perimetro, area, i);
rettangolo1.DisegnaRettangolo(rettangolo1.baseRettangolo, rettangolo1.altezzaRettangolo);


//RETTANGOLO 2
baseUtente = 0; hUtente = 0;
Rettangolo rettangolo2 = new Rettangolo();
i++;
Console.WriteLine("Inserisci in ordine base ed altezza del rettagolo " + i + ".");
baseUtente = int.Parse(Console.ReadLine());
hUtente = int.Parse(Console.ReadLine());

rettangolo2.baseRettangolo = baseUtente;
rettangolo2.altezzaRettangolo = hUtente;

area = rettangolo2.CalcolaArea(rettangolo2.baseRettangolo, rettangolo2.altezzaRettangolo);
perimetro = rettangolo2.CalcolaPerimetro(rettangolo2.baseRettangolo, rettangolo2.altezzaRettangolo);

rettangolo2.StampaRettangolo(perimetro, area, i);
rettangolo2.DisegnaRettangolo(rettangolo2.baseRettangolo, rettangolo2.altezzaRettangolo);




//RETTANGOLO 3
baseUtente = 0; hUtente = 0;
Rettangolo rettangolo3 = new Rettangolo();
i++;
Console.WriteLine("Inserisci in ordine base ed altezza del rettagolo " + i + ".");
baseUtente = int.Parse(Console.ReadLine());
hUtente = int.Parse(Console.ReadLine());

rettangolo3.baseRettangolo = baseUtente;
rettangolo3.altezzaRettangolo = hUtente;

area = rettangolo3.CalcolaArea(rettangolo3.baseRettangolo, rettangolo3.altezzaRettangolo);
perimetro = rettangolo3.CalcolaPerimetro(rettangolo3.baseRettangolo, rettangolo3.altezzaRettangolo);

rettangolo3.StampaRettangolo(perimetro, area, i);
rettangolo2.DisegnaRettangolo(rettangolo3.baseRettangolo, rettangolo3.altezzaRettangolo);
