using DomiProjekt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomiProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initial");

            Falu matyasbator = new Falu("09-18", "Utcafalu", "Magyar" , "Varga Dominik", 1767, "Mátyásbátor", "Hajdú-Bihar Megye", "Megye", "Hungarisztán", "Köztársaság", "Európa", "Magyar");
            matyasbator.ToString();
            Varos baja = new Varos("Megapolisz", "Halászlé", "Kiss Norber", 2, "Baja", "Bács-Kiskun" , "Megye", "Nagy Magyar Birodalom", "Monarchia", "Eurázsia", "Magyar");
            baja.ToString();
        }
    }
}
