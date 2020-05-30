using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diena15_task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            String[] text = File.ReadAllLines(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Task2\Test.txt");
            for (int i = 0; i < text.Length; i++) 
            {
                richTextBox1.Text += text[i] + "\n";
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String[] elementi = richTextBox1.Text.Split('\n');
            File.WriteAllLines(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Task2\Test.txt", elementi);
            //File.WriteAllLines(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Task2\Test234.txt", elementi); -> ja vajag cita faila
        }
    }
}
