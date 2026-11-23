using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomiProjekt.Model
{
    internal class Falu : Telepules
    {
       
        private string falunap;
        private string falutipus;
       
        private Nemzetisegek nemzetiseg;

        public Falu( string falunap, string falutipus, List<string> nemzetisegg, string polgarmester, int alapitasEve, string telepulesNev, string tartomanynev, string kategoria, string orszagNev, string allamForma, string foldresz, string nyelv) : base(polgarmester, alapitasEve, telepulesNev, tartomanynev, kategoria, orszagNev, allamForma, foldresz, nyelv)
        {
            Falunap = falunap;
            Falutipus = falutipus;
            nemzetiseg = new Nemzetisegek(nemzetisegg);
            
        }

        public string Falunap { get => falunap; set => falunap = value; }
        public string Falutipus { get => falutipus; set => falutipus = value; }

        internal Nemzetisegek Nemzetiseg { get => nemzetiseg; set => nemzetiseg = value; }

        public override void ToString()
        {
            Console.WriteLine($"{Foldresz}, {OrszagNev} ({AllamForma}, {Nyelv}), {TartomanyNev}-{Kategoria}, {TelepulesNev}, {Polgarmester}, {AlapitasEve}, Nemzetiségek: {Nemzetiseg.ToNationalitiesString()}, {falutipus}");
        }
    }
}
