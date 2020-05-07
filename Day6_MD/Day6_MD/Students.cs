using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_MD
{
    class Students
    {
        private static String vārds;
        private static String uzvārds;
        private static String kurss;

        public static void Studenti()
        {
            Console.WriteLine("Lūdzu, ievadiet savu vārdu!");
            setVārds(Console.ReadLine());
            Console.WriteLine("Lūdzu, ievadiet savu uzvārdu!");
            setUzvārds(Console.ReadLine());
            Console.WriteLine("Lūdzu, ievadiet sev vēlamo kursu (1-3)");
            setKurss(Console.ReadLine());
        }

        public static void setVārds(String a)
        {
            vārds = a;
        }

        public static String getVārds()
        {
            return vārds;
        }
        public static void setUzvārds(String a)
        {
            uzvārds = a;
        }

        public static String getUzvārds()
        {
            return uzvārds;
        }
        public static void setKurss(String a)
        {
            kurss = a;
        }

        public static String getKurss()
        {
            return kurss;
        }

        public static void print()
        {
            Console.WriteLine("Jūsu vārds ir " + getVārds() + " un uzvārds ir " + getUzvārds() + ", un Jūs esat izvēlējušies " + getKurss() + ". kursu!");
        }
    }
    
}
