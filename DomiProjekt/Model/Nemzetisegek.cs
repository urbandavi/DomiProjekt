using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomiProjekt.Model
{
    internal class Nemzetisegek
    {
        private List<string> nemzetisegek;

        public Nemzetisegek(List<string> nemzetisegekk)
        {
            Nemzetisegekk = nemzetisegekk;
        }

        public List<string> Nemzetisegekk { get => nemzetisegek; set => nemzetisegek = value; }

        public string ToNationalitiesString()
        {
            string res = "";
            for (int i = 0; i < Nemzetisegekk.Count(); i++)
            {
                res += $" {Nemzetisegekk[i]}";
            }
            return res;
        }

        public string GetNemzetisegById(int index)
        {
            return Nemzetisegekk[index];
        }
    }
}
