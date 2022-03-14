using System;
using System.Collections.Generic;
using System.Text;

namespace Hoone
{
    public abstract class KorteriteMaja : Hoone
    {
        public override void NaitaInfo()
        {
            Console.WriteLine($"Mul on KorteeriMaja");
        }
    }
}
