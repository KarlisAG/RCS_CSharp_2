using System;

namespace Day4_MD_Kārlis
{
    class Program
    {
        static void Main(string[] args)
        {
            Kāpināšana();
            //RandomNumber();
        }

        static void RandomNumber()
        {
            Random rnd = new Random();
            
            for (int i = 4; i > -1; i--)
            {
                Console.WriteLine("Cenšaties uzminēt random skaitli diapazonā no 1 līdz 20!");
                String ievade = Console.ReadLine();
                int ievadeC = Convert.ToInt32(ievade);
                int randomC = rnd.Next(1, 20);
                Console.WriteLine(randomC);
                if(ievadeC == randomC)
                {
                    Console.WriteLine("Apsveicam, Jūs uzminējāt pareizo ciparu!");
                    break;
                }
                else
                {
                    Console.WriteLine("Jūs diemžēl neuzminējāt, mēģinet vēlreiz. Jums vēl ir palikuši " + i + " mēģinājumi!");
                }

            }
        }

        static void Kāpināšana()
        {

        }
    }
}
/*1) Patstāvīgi atrast kā ģenerēt random skaitli. Lietotājs cenšas uzminēt skaitli piecas reizes, ja neizdodas, tad zaudē, ja izdodas, tad uzvar.


2) Izveidot metodi, kas padod divus int tipa skaitļus kā parametrus- bāzi un pakāpi. Metode atgriež kāpinājumu.
Piemērs, padod 2 un 3, tātad 2^3 = 2* *2 * 2 = 8

3) Izvadīt šādu piramīdu, izmantojot for ciklu.
1
2 3
4 5 6
7 8 9 10
*/