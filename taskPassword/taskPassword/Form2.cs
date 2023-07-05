using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskPassword
{
    public partial class Form2 : Form
    {
        public Form2(string rName)
        {
            InitializeComponent();
            Name2.Text=rName;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawEllipse(p, 200,60,170,170);
            MessageBox.Show("You Logined Sucessfully.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void txtmark2_TextChanged(object sender, EventArgs e)
        {
                      
        }
    }
}
