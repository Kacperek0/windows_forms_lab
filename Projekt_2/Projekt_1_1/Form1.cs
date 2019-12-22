using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double b;
            if (double.TryParse(textBox3.Text, out b) && b > 0)
            {
                textBox2.Text = Math.Pow(b, 2).ToString();
                textBox1.Text = (4* b).ToString();
                komunikat.Text = "Dane prawidłowe";
                //komunikat.Text = string.Empty;
            }
            else
            {
                komunikat.Text = "Wpisz dodatnią liczbę";
                
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Clear();
            komunikat.Text = "Wpisz wymiar boku";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void komunikat_Click(object sender, EventArgs e)
        {

        }

        private void kolor_Click(object sender, EventArgs e)
        {
            var formColor = new Form2();
            formColor.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Draw = new Form3();
            Draw.ShowDialog();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
