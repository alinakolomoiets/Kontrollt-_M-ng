using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltöö_Mäng
{
    public class Tegelane : Entity, IComparable<Tegelane>
    {
        private string nimi;
        List<Ese> esemed;
        public Tegelane(string nimi)
        {
            this.nimi = nimi; 
        }
        public int CompareTo(Tegelane? other)
        {
            if (other == null) return 1;
            return this.esemed.Count - other.ItemCount();
        }
        public int ItemCount() //
        { 
            return esemed.Count;
        }
        public int lisaEse(int arv) 
        {
            esemed.Add(ese);
            return arv; 
        }
        public int PunctideArv()//
        {
            int Sum=0;
            foreach (Ese item in esemed)
            { 
                Sum += item.PunctideArv();
            }
            return Sum;
        }
        public string Info() //
        {
            return $"See on {nimi}\n,  {esemed.Count}\n, Summa: {PunctideArv()}\n";

        }
        public void valjasataEsemed()
        {
            foreach(Ese ese in esemed)
            {
                Console.WriteLine(ese.Info());
            }
        }
        

    }
}
