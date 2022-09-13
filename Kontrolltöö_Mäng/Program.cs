using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltöö_mäng
{
    class Program 
    {
        static void Main(string[] args)
        {
            UTF8Encoding utf8 = new UTF8Encoding();

            StreamReader from_file = new StreamReader(@"..\..\..\arvutimängus.txt");
            string text = from_file.ReadToEnd();
            List<Ese> esed = new List<Ese>();
        }
