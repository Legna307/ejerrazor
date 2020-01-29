using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejerbykike.Models
{
    public class primos
    {
        public primos()
        {

        }
        public List<int>CalculaPrimos(int from,int until)
        {
            //creamos una lista de numeros
            List<int> primos = new List<int>();
            for (int i=from;i<=until;i++)
            {
                if(EsPrimo(i))
                {
                    primos.Add(i);
                }
            }
            return (primos);
        }
        private bool EsPrimo(int x)
        {
            if (x < 0)
                throw new ArgumentOutOfRangeException("x ", x, "Valor mayor que cero");
            if (x <= 3)
                return true;
            else
                for (int i = 2; i <= x - 1; i++)
                    if (x % i == 0)
                        return false;
            return true;
        }
    }
}