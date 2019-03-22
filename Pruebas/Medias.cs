using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Medias
    {
        /**
         * Calcula y regresa la media artimética
         */
        public static double mediaAritmetica(params int[] vals)
        {
            double sum = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                sum += vals[i];
            }
            return sum / vals.Length;

        }

        /**
         * Calcula y regresa la raíz enésima = x^(1/n)
         */
        private static double raizEnesima(double x, int n)
        {
            return Math.Pow(x, 1 / n);
        }

        /**
         *  Usa raizEnesima para calcular y regresar la media geométrica
         */
        public double mediaGeometrica(params int[] vals)
        {
            int multi = 1;
            for (int i = 0; i < vals.Length; i++)
            {
                multi = vals[i];
            }
            return raizEnesima(multi, vals.Length);
        }

        /**
         * Este método no está implementado.
         */
        public static double mediaArmonica(params int[] vals)
        {
            double sum = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                sum += 1 / vals[i];
            }
            return vals.Length / sum;
        }
    }
}
