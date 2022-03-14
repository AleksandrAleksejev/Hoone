using System;
using System.Collections.Generic;
using System.Text;

namespace Hoone
{
    static class Program
    {
        static void Main(string[] args)
        {
            EraMaja majake = new EraMaja();
            Inimene mees = new Inimene("Juku");
            majake.uks = new Uks("must");
            //  p.korteriNum = new korteriNum(27);
            //majaKorgus.uks = new Uks(20);
            mees.hoone = majake;
            mees.NaitaInfo();
        }
    }
}

