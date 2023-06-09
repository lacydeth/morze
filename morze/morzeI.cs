using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morze
{
    internal class morzeI
    {
        string morzeSzerzo;
        string morzeIdezet;

        public morzeI(string morzeSzerzo, string morzeIdezet)
        {
            this.morzeSzerzo = morzeSzerzo;
            this.morzeIdezet = morzeIdezet;
        }

        public string MorzeSzerzo { get => morzeSzerzo; set => morzeSzerzo = value; }
        public string MorzeIdezet { get => morzeIdezet; set => morzeIdezet = value; }
    }
}
