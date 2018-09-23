using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecimalARomano.Procesos;

namespace DecimalARomano
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversión Romano = new Conversión();
            while (true)
            {
                Console.Write("Escriba un número ({0} a {1}) a convertir: ", Romano.LOWEST, Romano.HIGHEST);
                try
                {
                    Romano.SetDecimal(int.Parse(Console.ReadLine()));
                    break;
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("El número convertido es: {0}", Romano.ConvertirDecimalARomano());
            Console.ReadLine();

        }
    }
}
