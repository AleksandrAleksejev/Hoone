using System;
using System.Collections.Generic;
using System.Text;

namespace Hoone
{

    public class EraMaja : Hoone
    {
        int suurus;
        int korteriNum;
        int korrus;

        public EraMaja(int pindala = 50) : base(pindala)
        {
        }
        public string Status
        {
            get
            {
                var status = "";
                if (suurus < 50)
                {
                    status = "vaike maja";
                }
                else if (suurus < 100)
                {
                    status = "keskmine maja";
                }
                else if (suurus < 200
                    )
                {
                    status = "suur maja";
                }
                else
                {
                    status = "liiga suur maja";
                }
                return status;
            }
        }
        public int KorteriNum
        {
            set{ KorteriNum = value; }
            get { return korteriNum; }

        }
        public int Korrus
        {
            set { korrus = value; }
            get { return korrus; }
        }
        public override void NaitaInfo()
        {
            Console.WriteLine($"Ma olen {Status}");
        }
    }
}