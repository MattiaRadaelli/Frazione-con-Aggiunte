﻿namespace ClasseFrazione
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Num = new System.Windows.Forms.TextBox();
            this.Den = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.piu = new System.Windows.Forms.Button();
            this.meno = new System.Windows.Forms.Button();
            this.prodotto = new System.Windows.Forms.Button();
            this.divisione = new System.Windows.Forms.Button();
            this.Semplifica = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(158, 56);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(47, 20);
            this.Num.TabIndex = 0;
            // 
            // Den
            // 
            this.Den.Location = new System.Drawing.Point(158, 89);
            this.Den.Name = "Den";
            this.Den.Size = new System.Drawing.Size(47, 20);
            this.Den.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "----------------";
            // 
            // piu
            // 
            this.piu.Location = new System.Drawing.Point(190, 132);
            this.piu.Name = "piu";
            this.piu.Size = new System.Drawing.Size(25, 23);
            this.piu.TabIndex = 3;
            this.piu.Text = "+";
            this.piu.UseVisualStyleBackColor = true;
            this.piu.Click += new System.EventHandler(this.piu_Click);
            // 
            // meno
            // 
            this.meno.Location = new System.Drawing.Point(106, 133);
            this.meno.Name = "meno";
            this.meno.Size = new System.Drawing.Size(25, 23);
            this.meno.TabIndex = 4;
            this.meno.Text = "-";
            this.meno.UseVisualStyleBackColor = true;
            this.meno.Click += new System.EventHandler(this.meno_Click);
            // 
            // prodotto
            // 
            this.prodotto.Location = new System.Drawing.Point(230, 132);
            this.prodotto.Name = "prodotto";
            this.prodotto.Size = new System.Drawing.Size(25, 23);
            this.prodotto.TabIndex = 5;
            this.prodotto.Text = "x";
            this.prodotto.UseVisualStyleBackColor = true;
            this.prodotto.Click += new System.EventHandler(this.prodotto_Click);
            // 
            // divisione
            // 
            this.divisione.Location = new System.Drawing.Point(147, 132);
            this.divisione.Name = "divisione";
            this.divisione.Size = new System.Drawing.Size(25, 24);
            this.divisione.TabIndex = 6;
            this.divisione.Text = "/";
            this.divisione.UseVisualStyleBackColor = true;
            this.divisione.Click += new System.EventHandler(this.divisione_Click_1);
            // 
            // Semplifica
            // 
            this.Semplifica.Location = new System.Drawing.Point(23, 56);
            this.Semplifica.Name = "Semplifica";
            this.Semplifica.Size = new System.Drawing.Size(82, 23);
            this.Semplifica.TabIndex = 7;
            this.Semplifica.Text = "Semplifica";
            this.Semplifica.UseVisualStyleBackColor = true;
            this.Semplifica.Click += new System.EventHandler(this.Semplifica_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Decimale";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Elevazione";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 20);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 189);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Semplifica);
            this.Controls.Add(this.divisione);
            this.Controls.Add(this.prodotto);
            this.Controls.Add(this.meno);
            this.Controls.Add(this.piu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Den);
            this.Controls.Add(this.Num);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.TextBox Den;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button piu;
        private System.Windows.Forms.Button meno;
        private System.Windows.Forms.Button prodotto;
        private System.Windows.Forms.Button divisione;
        private System.Windows.Forms.Button Semplifica;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

