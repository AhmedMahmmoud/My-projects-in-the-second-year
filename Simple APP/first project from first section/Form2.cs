using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_project_from_first_section
{
    public partial class Form2 : Form
    {
        public string name;
        public int age;
        public CheckedListBox ch = new CheckedListBox();
        public Form2(string name, int age, CheckedListBox c)
        {
            InitializeComponent();
            this.name = name;
            this.age = age;
            this.ch = c;
        }

        private void btninfo_Click(object sender, EventArgs e)
        {

        }

        private void btninfo_Click_1(object sender, EventArgs e)
        {

            {
                if (ch.CheckedItems.Count > 1)
                {
                    string s = "";
                    foreach (var item in ch.CheckedItems)
                    {
                        s += item + "\t";
                    }
                    MessageBox.Show("Hello" +" " + name + " " + "Thank for your registration your courses:" + s);
                }
                else
                {
                    MessageBox.Show("Thank you for verification" + " " + name + " " + "you selected course:" + ch.SelectedItem);
                }


            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}   
