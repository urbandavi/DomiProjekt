using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomiProjekt.Model
{
    internal class Varos : Telepules
    {
        private string tipus;
        private string specialitas;

        public Varos(string tipus, string specialitas, string polgarmester, int alapitasEve, string telepulesNev, string tartomanynev, string kategoria, string orszagNev, string allamForma, string foldresz, string nyelv) : base(polgarmester,alapitasEve,telepulesNev,tartomanynev, kategoria, orszagNev, allamForma, foldresz, nyelv)
        {
            Tipus = tipus;
            Specialitas = specialitas;
        }

        public string Tipus { get => tipus; set => tipus = value; }
        public string Specialitas { get => specialitas; set => specialitas = value; }

        public override void ToString()
        {
            Console.WriteLine($"{Foldresz}, {OrszagNev} ({AllamForma}, {Nyelv}), {TartomanyNev} {Kategoria}, {TelepulesNev}, {Polgarmester}, {AlapitasEve},  {Specialitas}, {Tipus}");
        }
    }
}
