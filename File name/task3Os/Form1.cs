using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace task3Os
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           FileStream fs = new FileStream ("data.txt",FileMode.Create,FileAccess.Write);
           StreamWriter sw = new StreamWriter (fs);
           string str = "Operating System Lab3";
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            FileStream s =new FileStream ("data.txt",FileMode.Open,FileAccess.Read);
            StreamReader sw2 = new StreamReader (s);
            sw2.BaseStream.Seek(0, SeekOrigin.Begin);
           string str2 = sw2.ReadLine();
            MessageBox.Show(str2);
            sw2.Close();         

        }
    }
}
