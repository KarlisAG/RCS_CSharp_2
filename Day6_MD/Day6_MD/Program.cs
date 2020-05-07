using System;

namespace Day6_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        static void Task1()
        {
            Students.Studenti();
            Students.print();
        }
    }
}
/*1) Izveidot klasi students
Lauki- vards, uzvards, kurss.
Uztaisīt tā, lai cilvēks ievada studenta vārdu, uzvārdu, kursu, kursam jābūt no 1-3.
Izveidot klasē metodi (publisku) print(), kas izvada visus laukus.

2) Izveidot kalkulatoru-
Visas ievades/izvades notiek Program.cs klasē, visi aprēķini jāizveido kā metodes ar parametriem un return vērtībām
*/