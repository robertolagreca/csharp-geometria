// See https://aka.ms/new-console-template for more information

//Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo.
//Aggiungere due metodi: calcolaArea e calcolaPerimetro che calcolano e restituiscono,
//rispettivamente, l’area e il perimetro del rettangolo.
//Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire,
//da console, i valori di base e di altezza con cui istanziare un nuovo Rettangolo.

//Dopo averlo istanziato, occupatevi di configurare le sue proprietà di base e altezza
//(come abbiamo fatto con le nostre auto questa mattina nel programma principale) e
//stampate a video il perimetro e l’area.

//Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi
//(baseRettangolo e altezzaRettangolo) e provate a stampare le loro proprietà
//ad esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo ad esempio cosi:
//—— Rettangolo1 ——
//base: 20 cm
//altezza: 10 cm
//Perimetro: 60 cm
//Area: 200 cm2

using Geometria;

int baseUtente, hUtente, perimetro, area;

Console.WriteLine("Inserisci in ordine base ed altezza.");
baseUtente = int.Parse(Console.ReadLine());
hUtente= int.Parse(Console.ReadLine());

Rettangolo rettangolo1= new Rettangolo();


rettangolo1.baseRettangolo = baseUtente;
rettangolo1.altezzaRettangolo = hUtente;

area = rettangolo1.CalcolaArea(rettangolo1.baseRettangolo, rettangolo1.altezzaRettangolo);
perimetro = rettangolo1.CalcolaPerimetro(rettangolo1.baseRettangolo, rettangolo1.altezzaRettangolo);

Console.WriteLine("-- Rettangolo 1 --");
Console.WriteLine();
Console.WriteLine("Base: \t" + rettangolo1.baseRettangolo);
Console.WriteLine("Altezza: \t" + rettangolo1.altezzaRettangolo);
Console.WriteLine("Perimetro: \t" + perimetro);
Console.WriteLine("Area: \t" + area);


