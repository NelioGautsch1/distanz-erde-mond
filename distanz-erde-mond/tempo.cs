using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distanz_erde_mond
{
    internal class tempo
    {
        public double geschwindigkeit { get; set; }

        public double ErhalteDauerInStunden()
            { return 384400 / geschwindigkeit; }
        public double ErhalteDauerInTagen()
            { return 384400 / geschwindigkeit / 24; }
    }
}