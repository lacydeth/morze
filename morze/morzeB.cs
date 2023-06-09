using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morze
{
    internal class morzeB
    {
        string morzeBetu;
        string morzeKod;

        public morzeB(string morzeBetu, string morzeKod)
        {
            this.morzeBetu = morzeBetu;
            this.morzeKod = morzeKod;
        }

        public string MorzeBetu { get => morzeBetu; set => morzeBetu = value; }
        public string MorzeKod { get => morzeKod; set => morzeKod = value; }
    }
}
