using System;
using System.Collections.Generic;

namespace Day7__Objects_Objekti
{
    class Program
    {
        static void Main(string[] args)
        {
            //ja ir static - tad objektu nelieto; statiskai vērtībai nevir piešķirt, to aks ir apredzēts objektam
            //statiskas metodes taisa, tad kad netaisa objektu??
            Trijsturis tr1 = new Trijsturis(1, 2, 3);//metodei jeb konstruktoram vajag tad uzreiz parametrus
            tr1.Print();//ja nav statiskas metodes, tad rakstot klasi un metodes, tad neko nevar izsaukt jeb Trijsturi. .. neder!
            //^^ bet rakstot objektu var tikt klāt!!

            Trijsturis tr2 = new Trijsturis(4, 5, 6);
            tr2.Print();


            Students st1 = new Students("Kārlis", "Gribulis", 2);
            st1.Print();

            Students st2 = new Students("Marija", "Soldatenko", 1);
            st2.Print();

            Students[] students = new Students[5];//katrā tad var 1 objektu; objekti klasē..?
            students[0] = new Students("Jānis", "Bērziņš", 3);


            List<Students> st = new List<Students>();//ja ir runa par objektiem, tad list ir daudz labāks
                                                     //ja uztaisa for ciklu uz i, ja arrayiem nav viss aizpildīs, tad crash
                                                     //listi nekrashos, garums pielāgosies; un var vienkārši add pie listes un būs ok

            Console.WriteLine("Lūdzu, ievadiet sava daudzstūra vēlamo malu garumus! Jums ir jāievada 3-5 dažādi cipari. Ja gribat tikai trīsstūri vai četrstūri, tad ievadiet tik dažādu malu garumus un pārējās ievadēs (kopā 5) ievadet jebkuru citu simbolu, atskaitot ciparus!");
            Shape daudzstūrisArIevadi = new Shape(Input(), Input(), Input(), Input(), Input());
            Shape daudzstūris = new Shape(3,4,5, 6);
            daudzstūrisArIevadi.Print();
            daudzstūrisArIevadi.Perimeter();

        }

        static int Input()
        {
            try
            {
                
                int ievade = Convert.ToInt32(Console.ReadLine());
                return ievade;
            }
            catch 
            {
                return 0;
            }

        }
    }
}
