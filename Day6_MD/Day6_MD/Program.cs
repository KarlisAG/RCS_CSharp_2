using System;

namespace Day6_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Console.WriteLine();
            //Task2();
            Console.WriteLine("Ievadiet vārdu!");
            PasniedzējaStudent.setName(Console.ReadLine());

            Console.WriteLine("ievadiet uzvārdu!");
            PasniedzējaStudent.setSurname(Console.ReadLine());

            Console.WriteLine("Ievadiet kursu!");
            try
            {
                PasniedzējaStudent.setCourse(Convert.ToInt32(Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("Nepareiza ievade");
                return;
            }

            PasniedzējaStudent.print();
            
        }

        static void Task1()
        {
            Students.Studenti();
            Students.print();
        }

        static void Task2()
        {
            bool turpinājums = true;
            Console.WriteLine("Sveiki! Šis ir mazais kalkulators! Lai ar to darbotos Jums vajag atsevišķi ievadīt vienu skaitli, tad ievadīt kādu darbību Jūs vēlaties ( +, -, * vai / ) un trešajā reizē ievadiet otro ciparu!"); ;

            do
            {
                Console.WriteLine("1. ievade (pirmais skaitlis)");
                double ievadeC1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("2. ievade (darbība ( +, -, *, / ))");
                String darbība = Console.ReadLine();
                Console.WriteLine("3. ievade (otrais skaitlis)");
                double ievadeC2 = Convert.ToDouble(Console.ReadLine());

                switch (darbība)
                {
                    case "+":
                        Console.WriteLine("Rezultāts ir " + Kalkulators.Saskaitīšana(ievadeC1, ievadeC2));
                        break;
                    case "-":
                        Console.WriteLine("Rezultāts ir " + Kalkulators.Atņemšana(ievadeC1, ievadeC2));
                        break;
                    case "*":
                        Console.WriteLine("Rezultāts ir " + Kalkulators.Reizināšana(ievadeC1, ievadeC2));
                        break;
                    case "/":
                        Console.WriteLine("Rezultāts ir " + Kalkulators.Dalīšana(ievadeC1, ievadeC2));
                        break;
                }
                Console.WriteLine("Vai vēlaties turpināt (lai turpinātu, ievadiet pilnīgi jebko)? Ja gribat šo procesu apstādināt ierakstiet STOP");
                String ievadeStop = "STOP";
                if (ievadeStop == Console.ReadLine())
                {
                    turpinājums = false;
                }
                Console.WriteLine();
            } while (turpinājums == true);

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