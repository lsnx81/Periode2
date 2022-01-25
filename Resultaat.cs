using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapportModule
{
    internal class Resultaat
    {
        public int Percentage { get; set; } = -1;

        internal void PrintGraad()
        {
            if (Percentage < 0)
            {
                throw new Exception("Percentage niet toegewezen");
            }
            string message;
            if (Percentage > 85)
            {
                message = "Grootste Onderscheiding";
            }
            else if (Percentage > 75)
            {
                message = "Grote Onderscheiding";
            }
            else if (Percentage > 68)
            {
                message = "Onderscheiding";
            }
            else if (Percentage > 50)
            {
                message = "voldoende";
            }
            else
            {
                message = "Niet Geslaagd";
            }
            Console.WriteLine(message);
        }
    }
}



/*

< 50: niet geslaagd;
tussen 50 en 68: voldoende;
tussen 68 en 75: onderscheiding;
tussen 75 en 85: grote onderscheiding;
> 85: grootste onderscheiding.
*/
