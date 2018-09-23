using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalARomano.Procesos
{
    class Conversión
    {
        public int LOWEST = 0;
        public int HIGHEST = 3999;
        private int dec;
        List<byte> Magnitud = new List<byte>();
        string unos = "IXCM";
        string cincos = "VLD";

        public void SetDecimal(int dec)
        {
            if (dec < LOWEST || dec > HIGHEST) throw new ArgumentOutOfRangeException();
            this.dec = dec;
        }

        public string ConvertirDecimalARomano()
        {
            string resultado = "";

            while (dec != 0)
            {
                Magnitud.Add(Convert.ToByte(dec % 10));
                dec /= 10;
            }
            for (int index = 0; index < Magnitud.Count; index++)
            {
                switch (Magnitud[index])
                {
                    case 1: resultado = string.Concat(unos[index], resultado); break;
                    case 2: resultado = string.Concat(unos[index], unos[index], resultado); break;
                    case 3: resultado = string.Concat(unos[index], unos[index], unos[index], resultado); break;
                    case 4: resultado = string.Concat(unos[index], cincos[index], resultado); break;
                    case 5: resultado = string.Concat(cincos[index], resultado); break;
                    case 6: resultado = string.Concat(cincos[index], unos[index], resultado); break;
                    case 7: resultado = string.Concat(cincos[index], unos[index], unos[index], resultado); break;
                    case 8: resultado = string.Concat(cincos[index], unos[index], unos[index], unos[index], resultado); break;
                    case 9: resultado = string.Concat(unos[index], unos[index + 1], resultado); break;
                }
            }
            return resultado;
        }
    }
}
