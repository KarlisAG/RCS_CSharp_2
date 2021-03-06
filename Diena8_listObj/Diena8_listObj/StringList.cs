﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Diena8_listObj
{
    class StringList
    {
        private List<String> listOfValues;

        public StringList()
        {
            listOfValues = new List<String>() {"aa", "bb"};//šādi uzrei ieliek vērtības
            //() parāda, ka tā ir metode
        }

        public void Task1()
        {
            //mēs izvadam menu
            //doda cilvēkam iespēju izvēlēties
            //1. izvadīt
            //2. pievienot
            //3. dzēst
            //0. iziet
            String izvēle = "";
            while (izvēle != "0")
            {
                Console.WriteLine("Sveiki, Jums ir iespēja");
                Console.WriteLine("1 - izvadīt sarakstu");
                Console.WriteLine("2 - pievienot ievadi sarakstam");
                Console.WriteLine("3 - dzēst kādu vērtību ierakstītajā indeksā");
                Console.WriteLine("4 - meklēt konkrētu lietu sarakstā");
                Console.WriteLine("0 - apturēt programmu!");

                izvēle = Console.ReadLine();

                switch (izvēle)
                {
                    case "1":
                        Print();
                        break;
                    case "2":
                        Add();
                        break;
                    case "3":
                        Delete();
                        break;
                    case "0":
                        break;
                    case "4":
                        PasniedzejaSearch();
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade!");
                        break;
                }
            }

        }

        private void Print()
        {
            //1. izvadīt
            

            if (listOfValues.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukšs!");
            }
            else
            {
                Console.WriteLine("Sarakstā atrodas: ");
                foreach (String a in listOfValues)
                {
                    Console.WriteLine(a);
                }
            }
        }

        private void Add()
        {
            //2. pievienot
            Console.WriteLine("Ievadiet, ko Jūs vēlaties pievienot sarakstam!");
            listOfValues.Add(Console.ReadLine());
        }

        private void Delete()
        {
            //3. dzēst
            Console.WriteLine("Kādu indeksu vēlaties izdzēst?");
            try
            {
                int izvēle = Convert.ToInt32(Console.ReadLine());
                listOfValues.RemoveAt(izvēle);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Šāds indekss sarakstā nav!");
            }

        }

        private void PasniedzējaDelete()
        {
            for (int i = 0; i < listOfValues.Count; i++)
            {
                Console.WriteLine(i + " - " + listOfValues[i]);//parāda kurā indeksā ir kāds elements
            }
            Console.WriteLine("Kādu indeksu vēlaties izdzēst?");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                listOfValues.RemoveAt(choice);
            }
            catch
            {
                Console.WriteLine("Nepareiza ievade!");
            }

        }

        private void Search()
        {
            Console.WriteLine("Ievadiet ko Jus velaties atrast");
            String search = Console.ReadLine();
            for (int i = 0; i < listOfValues.Count; i++)
            {
                if (listOfValues.Contains(search))
                {
                    Console.WriteLine("Jusu elements atrodas indeksa: " + listOfValues.IndexOf(search));

                }
                else
                {
                    Console.WriteLine("Tads elements saraksta nav!");
                }
            }
        }

        private void PasniedzejaSearch()
        {
            Console.WriteLine("Ievadiet meklejamo frazi!");
            String toSearch = Console.ReadLine();
            Console.WriteLine("Mekletais atrodas: ");

            bool found = false;

            for (int i = 0; i < listOfValues.Count; i++)
            {
                String el = listOfValues[i].ToUpper();//lai atrastu, ja ir miksēti lielie un mazie
                if (listOfValues[i].Contains(toSearch))
                {
                    Console.Write(i + ", ");
                    found = true;
                }
                //if (el.Contains(toSearch.ToUpper())
                //{
                //    Console.Write(i + ", ");
                //    found = true;
                //}
            }

            if (!found)//!found - found = false
            {
                Console.WriteLine("Saraksts ir tukss");
            }
        }
    }
}
