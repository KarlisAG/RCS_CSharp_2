using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Diena15_FileIO
{
    class Example
    {
        public static void Read()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(@"C:\Users\akots\OneDrive\Työpöytä\LU VFF\Text.txt");//tur jānorāda ceļā C:\\Users\\... -> vajag \\, jo \ ir jauna rinda // ar @ nevajah \\, pietiek tikai ar \, jo vins pats saprot ka tas jauztver

                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);

                    line = sr.ReadLine();
                }

                sr.Close();//jataisa ciet, lai mazak kludu butu
            }
            catch
            {
                Console.WriteLine("Neizdevas atvert failu!");
            }
        } 

        public static void Write()
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\akots\OneDrive\Työpöytä\LU VFF\Text.txt", true); //ja padod jaulu, kas neeksiste, tad vins pats uztaisis jaunu failu tur
                //^^ ar to true, tad vins nevis parrkasta pari, bet pieraksta klat
                sw.WriteLine("ello!");
                sw.WriteLine("from the other side");

                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila");
            }
        }
    }
}
