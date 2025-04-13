using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saloomaatt_V2.Samandar
{
    internal class Faktorial
    {
        public static int Faktoriall(int son)
        {
            int natija = 1;
            for (int i = 1; i <= son; i++)
            {
                natija *= i;
            }
            return natija;
        }
    }
}
