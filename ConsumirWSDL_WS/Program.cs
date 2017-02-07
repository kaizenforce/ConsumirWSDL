using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirWSDL_WS
{
    class Program
    {
        static void Main(string[] args)
        {

            MiPrimerWS.GlobalWeatherSoapClient WS = new MiPrimerWS.GlobalWeatherSoapClient();

           string ListaCiudadesPeru= WS.GetCitiesByCountry("PERU");

           Console.WriteLine("Las ciudades del Perú son : " + ListaCiudadesPeru);

           Console.WriteLine("");

           string ListaCiudadesBrazil = WS.GetCitiesByCountry("BRAZIL");

           Console.WriteLine("Las ciudades del Perú son : " + ListaCiudadesBrazil);

           Console.WriteLine("");

           Console.ReadKey();

        }
    }
}
