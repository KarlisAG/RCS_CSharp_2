using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Diena15_FileIO
{
    class Task2
    {
        public static void Reverse()
        {
            String[] text = File.ReadAllLines(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Task2\Test.txt");

            Array.Reverse(text);
            File.WriteAllLines(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Task2\Test_new2.txt", text);
        }
    }
}
