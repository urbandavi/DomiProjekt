using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomiProjekt.Model
{
    internal abstract class Tartomany : Orszag
    {
        private string tartomanyNev;
        private string kategoria;

        public Tartomany(string tartomanyNev, string kategoria, string orszagNev, string allamforma, string kontinens, string nyelv) : base(orszagNev, allamforma, kontinens, nyelv)
        {
            TartomanyNev = tartomanyNev;
            Kategoria = kategoria;
        }

        protected string TartomanyNev { get => tartomanyNev; set => tartomanyNev = value; }
        protected string Kategoria { get => kategoria; set => kategoria = value; }


    }
}
