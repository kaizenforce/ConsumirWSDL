using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsumiendoWebServices
{
    class Program
    {
        static void Main(string[] args)
        {

            Prueba.GlobalWeatherSoapClient ws = new Prueba.GlobalWeatherSoapClient();

            string ListaCiudades = ws.GetCitiesByCountry("PERU");

            Console.WriteLine(ListaCiudades);
            Console.ReadKey();
        }
    }
}
