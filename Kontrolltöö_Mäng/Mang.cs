using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltöö_Mäng
{
    class Mang
    {
        private Tegelane[] mängijad;
        public Mang(Tegelane[] mängijad)
        {
            this.mängijad= mängijad;
        }
        public List<Tegelane> SuurimaEsemedArv()
        {
            List<Tegelane> võitjad = new List<Tegelane>();
            Tegelane sorted = mängijad[0];
            foreach(Tegelane t in mängijad)
            {
                int num =sorted.CompareTo(t);
                if (num < 0)
                {
                    sorted = t;
                    võitjad.Clear();
                }
                if (num==0) võitjad.Add(t);
            }
            võitjad.Add(sorted);
            return võitjad;
        }
        public Tegelane suurimaPunktideArv()
        {
            int parim = 0;
            Tegelane võitjad = mängijad[0];
            foreach (var t in mängijad)
            {
                int arv = t.PunctideArv();
                if (arv>parim)
                {
                    parim = arv;
                    võitjad = t;
                }
            }
            return võitjad;
        }
    }
}
