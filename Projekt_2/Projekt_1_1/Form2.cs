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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Color_Load(object sender, EventArgs e)
        {

        }

        private void zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zamknij_program_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            panel1.BackColor = colorDialog1.Color;
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            byte a;
            if (byte.TryParse(textBox1.Text, out a) && a > 0)
            {
                if (!panel1.Visible)
                {
                    panel1.Visible = true;
                }
                textBox1.Text = a.ToString();
                panel1.Width = a;
                panel1.Height = a;
                label2.Text = string.Empty;
            }
            else
            {
                label2.Text = "Wybierz inna liczbe od 1 do 256";
            }
        }
    }
}
