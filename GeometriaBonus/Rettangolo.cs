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

            public void StampaRettangolo(int perimetro,int area, int i)
             {

            Console.WriteLine("-- Rettangolo " + i +" --");
            Console.WriteLine();
            Console.WriteLine("Base: \t" + baseRettangolo);
            Console.WriteLine("Altezza: \t" + altezzaRettangolo);
            Console.WriteLine("Perimetro: \t" + perimetro);
            Console.WriteLine("Area: \t" + area);
            Console.WriteLine();

        }

        public void DisegnaRettangolo(int b, int h)
        {
            string baseDisegnata ="";

            for (int i = 0; i < b; i++)
            {
                if (i == 0)
                {
                    Console.Write("    __ ");
                    baseDisegnata += "     ";
                }
                else if (i > 0 && i < b - 1)
                {
                    Console.Write(" __ ");
                    baseDisegnata += "    ";
                } else
                {
                    Console.WriteLine(" __  ");
                    baseDisegnata += "     ";
                }

            }
            Console.WriteLine("");
            for (int i = 0; i < h; i++)
            {
                Console.WriteLine(" |" + baseDisegnata + "| ");
                Console.WriteLine("");

            }

            for (int i = 0; i < b; i++)
            {
                if (i == 0)
                {
                    Console.Write("    __ ");
                    
                }
                else if (i > 0 && i < b - 1)
                {
                    Console.Write(" __ ");
                    
                }
                else
                {
                    Console.WriteLine(" __  ");
                    
                }

            }

            Console.WriteLine("");
        }
    }
}
