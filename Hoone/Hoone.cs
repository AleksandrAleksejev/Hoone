using System;

namespace Hoone
{
    public abstract  class Hoone
    {

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
        public abstract void NaitaInfo();
    }
}
