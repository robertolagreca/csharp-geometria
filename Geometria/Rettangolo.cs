using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rettangolo
    {

            public int baseRettangolo;
            public int altezzaRettangolo;

            public int CalcolaArea(int b, int h)
            {
            int area;
            area = b * h;

            return area;
            }
        
            public int CalcolaPerimetro(int b, int h) 
            {
            int perimetro;
            perimetro = (b * 2) + (h * 2);

            return perimetro;
            }

            public void StampaRettangolo(int perimetro,int area)
             {
            Console.WriteLine("-- Rettangolo 1 --");
            Console.WriteLine();
            Console.WriteLine("Base: \t" + baseRettangolo);
            Console.WriteLine("Altezza: \t" + altezzaRettangolo);
            Console.WriteLine("Perimetro: \t" + perimetro);
            Console.WriteLine("Area: \t" + area);
        }
    }
}
