namespace Projekt_1_1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.komunikat = new System.Windows.Forms.Label();
            this.Obwod = new System.Windows.Forms.Label();
            this.Pole = new System.Windows.Forms.Label();
            this.bok = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.kolor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // komunikat
            // 
            this.komunikat.AutoSize = true;
            this.komunikat.ForeColor = System.Drawing.Color.Red;
            this.komunikat.Location = new System.Drawing.Point(316, 32);
            this.komunikat.Name = "komunikat";
            this.komunikat.Size = new System.Drawing.Size(0, 13);
            this.komunikat.TabIndex = 0;
            this.komunikat.Click += new System.EventHandler(this.komunikat_Click);
            // 
            // Obwod
            // 
            this.Obwod.AutoSize = true;
            this.Obwod.Location = new System.Drawing.Point(81, 118);
            this.Obwod.Name = "Obwod";
            this.Obwod.Size = new System.Drawing.Size(41, 13);
            this.Obwod.TabIndex = 1;
            this.Obwod.Text = "Obwód";
            // 
            // Pole
            // 
            this.Pole.AutoSize = true;
            this.Pole.Location = new System.Drawing.Point(81, 74);
            this.Pole.Name = "Pole";
            this.Pole.Size = new System.Drawing.Size(28, 13);
            this.Pole.TabIndex = 2;
            this.Pole.Text = "Pole";
            // 
            // bok
            // 
            this.bok.AutoSize = true;
            this.bok.Location = new System.Drawing.Point(81, 35);
            this.bok.Name = "bok";
            this.bok.Size = new System.Drawing.Size(26, 13);
            this.bok.TabIndex = 3;
            this.bok.Text = "Bok";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(350, 118);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(350, 71);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 5;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(169, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // kolor
            // 
            this.kolor.Location = new System.Drawing.Point(350, 168);
            this.kolor.Name = "kolor";
            this.kolor.Size = new System.Drawing.Size(75, 23);
            this.kolor.TabIndex = 9;
            this.kolor.Text = "kolor";
            this.kolor.UseVisualStyleBackColor = true;
            this.kolor.Click += new System.EventHandler(this.kolor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 409);
            this.Controls.Add(this.kolor);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.bok);
            this.Controls.Add(this.Pole);
            this.Controls.Add(this.Obwod);
            this.Controls.Add(this.komunikat);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label komunikat;
        private System.Windows.Forms.Label Obwod;
        private System.Windows.Forms.Label Pole;
        private System.Windows.Forms.Label bok;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button kolor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

