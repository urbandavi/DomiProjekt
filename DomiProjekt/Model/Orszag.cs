using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomiProjekt.Model
{
    internal abstract class Orszag
    {
        private string orszagNev;
        private string allamForma;
        private string foldresz;
        private string nyelv;

        protected Orszag(string orszagNev, string allamForma, string foldresz, string nyelv)
        {
            OrszagNev = orszagNev;
            AllamForma = allamForma;
            Foldresz = foldresz;
            Nyelv = nyelv;
        }

        protected string OrszagNev { get => orszagNev; set => orszagNev = value; }
        protected string AllamForma { get => allamForma; set => allamForma = value; }
        protected string Foldresz { get => foldresz; set => foldresz = value; }
        protected string Nyelv { get => nyelv; set => nyelv = value; }

        public abstract void ToString();


    }
}
