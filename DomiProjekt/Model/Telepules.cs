using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomiProjekt.Model
{
    internal abstract class Telepules : Tartomany
    {

        private string polgarmester;
        private int alapitasEve;

        private string telepulesNev;

        public Telepules(string tartomanyNev, string kategoria, string orszagNev, string allamforma, string kontinens, string nyelv) : base(tartomanyNev, kategoria, orszagNev, allamforma, kontinens, nyelv)
        {
        }

        protected Telepules(string polgarmester, int alapitasEve, string telepulesNev, string tartomanynev, string kategoria, string orszagNev, string allamForma, string foldresz, string nyelv) : base(tartomanynev, kategoria,orszagNev, allamForma, foldresz, nyelv)
        {
            Polgarmester = polgarmester;
            AlapitasEve = alapitasEve;
            TelepulesNev = telepulesNev;
        }

        protected string Polgarmester { get => polgarmester; set => polgarmester = value; }
        protected int AlapitasEve { get => alapitasEve; set => alapitasEve = value; }
        protected string TelepulesNev { get => telepulesNev; set => telepulesNev = value; }
    }
}
