﻿using System;

namespace Day7__Objects_Objekti
{
    class Program
    {
        static void Main(string[] args)
        {
            //statiskas metodes taisa, tad kad netaisa objektu??
            Trijsturis tr1 = new Trijsturis();
            tr1.mala1 = 44;
            tr1.Print();//ja nav statiskas metodes, tad rakstot klasi un metodes, tad neko nevar izsaukt jeb Trijsturi. .. neder!
            //^^ bet rakstot objektu var tikt klāt!!

            Trijsturis tr2 = new Trijsturis();
            tr2.mala2 = 3;
            tr2.Print();

        }
    }
}
