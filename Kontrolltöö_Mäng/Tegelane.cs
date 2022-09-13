using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltöö_Mäng
{
    public class Tegelane : Entity
    {
        string nimi;
        List<Ese> esemed;
        public Tegelane(string nimi)
        {
            this.nimi = nimi;
            esemed = new List<Ese>();  
        }
        
    }


}
