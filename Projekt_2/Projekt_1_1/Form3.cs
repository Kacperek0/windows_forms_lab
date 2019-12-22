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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void forgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fgColor = new ColorDialog();
            if (fgColor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                button1.ForeColor = fgColor.Color;
            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog bgColor = new ColorDialog();
            if (bgColor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                button1.BackColor = bgColor.Color;
            }
        }
    }
}
