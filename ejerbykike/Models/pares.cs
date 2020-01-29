using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejerbykike.Models
{
    public class pares
    {

        public List<int> CalculaPar(int from, int until)
        {
            //creamos una lista de numeros
            List<int> pares = new List<int>();
            for (int i = from; i <= until; i++)
            {
                if (EsPar(i))
                {
                    pares.Add(i);
                }
            }
            return (pares);
        }
        public static bool EsPar(int x)
        {
            return Convert.ToBoolean((x % 2 == 0 ? true : false));
        }
    }
}
