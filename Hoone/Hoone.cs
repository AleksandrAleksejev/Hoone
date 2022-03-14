using System;

namespace Hoone
{
    public abstract  class Hoone
    {
        int majaKorgus;
        int korteriArv;

        public int Pindala { get; set; }
        public Uks uks;

        public Hoone(int pindala = 200)
        {
            Pindala = pindala;
        }
        public Uks GetUks()
        {
            return uks;
        }
        public int KorteriArv
        {
            set {korteriArv = value; }
            get {return korteriArv; }
        }
        public int MajaKorgus
        {
            set { majaKorgus = value; }
            get { return majaKorgus; }
        }
        public abstract void NaitaInfo();
    }
}
