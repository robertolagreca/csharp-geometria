using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rettangolo
    {
        
            int baseRettangolo;
            int altezzaRettangolo;

            public int calcolaArea(int b, int h)
            {
            int area;
            area = (b * h) / 2;

            return area;
            }
        
    }
}
