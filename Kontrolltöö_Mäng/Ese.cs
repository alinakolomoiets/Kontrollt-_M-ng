using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltöö_Mäng
{
    public class Ese : Entity
    {
        private int arvu;
        private string nimetus;

        public Ese (int arvu , string nimetus)
        {
            this.arvu = arvu ;
            this.nimetus = nimetus;
        }
        public int PunctideArv() {return arvu; }
        public string Info() {return nimetus; }
    }
}
