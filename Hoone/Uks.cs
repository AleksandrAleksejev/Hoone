using System;
using System.Collections.Generic;
using System.Text;

namespace Hoone
{
    public class Uks : Hoone
    {
        public string Color { get; set; }

        public Uks(string color = "sinine")
        {
            Color = color;
        }
        public override void NaitaInfo()
        {
            Console.WriteLine($"Mina olen uks, minu värv on {Color}");
        }
        public int MajaKorgus { get; set; }

        public Uks(int majaKorgus = 20)
        {
            MajaKorgus = majaKorgus;
        }
        public int KorteriArv { get; set; }

        public Uks(int korteriArv = 15)
        {
            KorteriArv = korteriArv;
        }
        public int Pindala { get; set; }
        public Uks uks;

    }
}
