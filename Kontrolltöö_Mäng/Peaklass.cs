﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltöö_Mäng
{
    internal class Peaklass
    {
        public static List<Ese> LoeEsemed()
        {
           List<Ese> esed = new List<Ese>();
            using(StreamReader sr = new StreamReader(@"..\..\..\arvutimängus.txt"))
            {
                while(!sr.EndOfStream)
                {
                    string[] rida = sr.ReadLine().Split(";");
                    Ese ese = new Ese(Int32.Parse(rida[0]),rida[1].ToString());
                    esed.Add(ese);

                }
                return esed;

            }
          
        }
        public static Random rnd = new Random();
        static string RandomSym() //return random name from random sybmbols
        {
            string[] name = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "l", "k" };
            return name[rnd.Next(name.Length)];
        }
        static Tegelane[] Mängijad(int tegela)
        {
            if (tegela < 2) throw new Exception();
            Tegelane[] mängijad = new Tegelane[tegela];
            for (int i = 0; i < tegela; i++)
            {
                Tegelane mängija = new Tegelane(RandomSym());
                mängijad[i] = mängija;
            }
            List<Ese> esede = LoeEsemed();
            if (esed.Count<=0) throw new ArgumentOutOfRangeException();
            foreach(Tegelane m in mängijad)
            {
                Shuffle(esede);
                int esedekogus = rnd.Next(2, 10);
                for (int i = 0; i < esedekogus; i++)
                {
                    m.lisaEse(esede[i]);
                }
                return mängijad;
            }
        }
    }

}



























