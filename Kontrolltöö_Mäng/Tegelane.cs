using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltöö_Mäng
{
    public class Tegelane : Entity, IComparable<Tegelane>
    {
        string nimi;
        List<Ese> esemed;
        public Tegelane(string nimi)
        {
            this.nimi = nimi;
            esemed = new List<Ese>();  
        }
        public int CompareTo(Tegelane? other)
        {
            if (other == null) return 1;
            return this.esemed.Count - other.ItemCount();
        }
        public int ItemCount() //считывает и запоминает новый элемент
        { 
            return esemed.Count;
        }
        public int PunctideArv()//суммирует кол-во очков с предметов
        {
            int Sum=0;
            foreach (Ese item in esemed)
            { 
                Sum += item.PunctideArv();
            }
            return Sum;
        }
        public string Info() // показывает информацию о персонаже
        {
            return $"See on {nimi}\n,  {esemed.Count}\n, Summa: {PunctideArv()}\n";
        }
      


    }


}
