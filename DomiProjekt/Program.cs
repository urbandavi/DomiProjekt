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
            List<Varos> varosokList = new List<Varos>();
            List<Falu> falukList = new List<Falu>();


            telepulesHozzaadas(ref varosokList, ref falukList);


            

        }

        private static void telepulesHozzaadas(ref List<Varos> varosokList, ref List<Falu> falukList)
        {
            Console.WriteLine("Új város hozzáadása(1): ");
            Console.WriteLine("Új falu hozzáadása(2): ");
            Console.WriteLine("Adatok megjelenítése(3): ");
            int menuValasz = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (menuValasz == 1)
            {
                Console.WriteLine("Városnév: ");
                string varosNevInput = Console.ReadLine();

                Console.WriteLine("Várostipus: ");
                string varosTipusInput = Console.ReadLine();

                Console.WriteLine("Polgármester: ");
                string polgarmesterInput = Console.ReadLine();

                Console.WriteLine("Megye: ");
                string megyeNevInput = Console.ReadLine();

                Console.WriteLine("Régió típus: ");
                string megyeTipusInput = Console.ReadLine();

                Console.WriteLine("Ország neve: ");
                string orszagNevInput = Console.ReadLine();

                Console.WriteLine("Államforma: ");
                string allamFormaInput = Console.ReadLine();

                Console.WriteLine("Ország nyelve: ");
                string nyelvInput = Console.ReadLine();

                Console.WriteLine("Földrész: ");
                string foldreszInput = Console.ReadLine();

                Console.WriteLine("Város alapítás éve: ");
                int alapitasEvInput = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Specialitás: ");
                string specialitasInput = Console.ReadLine();

                Varos varos = new Varos(varosTipusInput, specialitasInput, polgarmesterInput, alapitasEvInput, varosNevInput, megyeNevInput, megyeTipusInput, orszagNevInput, allamFormaInput, foldreszInput, nyelvInput);
                varosokList.Add(varos);
                Console.Clear();
                varos.ToString();
                telepulesHozzaadas(ref varosokList, ref falukList);
            }
            else if (menuValasz == 2)
            {
                List<string> nemzetisegLista = new List<string>();

                Console.WriteLine("Falunév: ");
                string faluNevInput = Console.ReadLine();

                Console.WriteLine("Falutípus: ");
                string faluTipusInput = Console.ReadLine();

                Console.WriteLine("Falunap: ");
                string falunapInput = Console.ReadLine();

                Console.WriteLine("Polgármester: ");
                string polgarmesterInput = Console.ReadLine();

                Console.WriteLine("Megye: ");
                string megyeNevInput = Console.ReadLine();

                Console.WriteLine("Régió típus: ");
                string megyeTipusInput = Console.ReadLine();

                Console.WriteLine("Ország neve: ");
                string orszagNevInput = Console.ReadLine();

                Console.WriteLine("Államforma: ");
                string allamFormaInput = Console.ReadLine();

                Console.WriteLine("Földrész: ");
                string foldreszInput = Console.ReadLine();

                Console.WriteLine("Falu alapítás éve: ");
                int alapitasEvInput = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ország nyelve: ");
                string nyelvInput = Console.ReadLine();

                Console.WriteLine("Nemzetiségek száma: ");
                int nemzetisegekSzama = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < nemzetisegekSzama; i++)
                {
                    Console.WriteLine("Nemzetiség hozzáadása: ");
                    string nemzetisegInput = Console.ReadLine();
                    nemzetisegLista.Add(nemzetisegInput);
                }

                Falu falu = new Falu(falunapInput, faluTipusInput, nemzetisegLista, polgarmesterInput, alapitasEvInput, faluNevInput, megyeNevInput, megyeTipusInput, orszagNevInput, allamFormaInput, foldreszInput, nyelvInput);
                falukList.Add(falu);
                Console.Clear();
                falu.ToString();
                telepulesHozzaadas(ref varosokList, ref falukList);
            }
            else if (menuValasz == 3)
            {
                foreach (var item in varosokList)
                {
                    item.ToString();
                }
                Console.WriteLine("-----------------------------------------------------------------------");
                foreach (var item in falukList)
                {
                    item.ToString();
                }
                Console.WriteLine("Menü");
                Console.ReadLine();
                telepulesHozzaadas(ref varosokList, ref falukList);
            }
        }
    }
}
