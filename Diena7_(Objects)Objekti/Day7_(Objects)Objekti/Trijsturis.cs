using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Day7__Objects_Objekti
{
    class Trijsturis//var bū public, var nē; vienalga
    {
        private int mala1;
        private int mala2;
        private int mala3;

        public Trijsturis(int mala1, int mala2, int mala3)//konstruktors - pirmais, kas izpidlīsies, kad uztaisīs objektu
        {
            //ērti izmantot, kad objektam jāpiešķir kādas defaultās vērtības
            this.mala1 = mala1;//vairs nevar Trijsturis.mala1 = mala1; jo metode vairs nav statiska, tāpēc objekts katru reizi būs cits
            this.mala2 = mala2;//Jr izsauks tr1, tad this norādīs uz tr1 lauku, ja tr2, tad tr2 lauku
            this.mala3 = mala3;//ar this saprot, ka ir jāizmanto lauks, ne lokālā vērtība
        }

        public void Print()
        {
            Console.WriteLine(mala1 + " " + mala2 + " " + mala3);
        }
    }
}
