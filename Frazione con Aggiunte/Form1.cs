﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseFrazione
{
    public partial class Form1 : Form
    {
        Frazione frazione = new Frazione();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }        

        public bool Inserimento()
        {
            bool giusto = float.TryParse(Num.Text, out _) == true && float.TryParse(Den.Text, out _) == true && Num.Text != string.Empty && Den.Text != string.Empty && Den.Text != "0";
            if (giusto == true)
            {
                frazione._numeratore = float.Parse(Num.Text);
                frazione._denominatore = float.Parse(Den.Text);
                if (frazione._numeratore < 0 && frazione._denominatore > 0)
                {
                    frazione._numeratore = -frazione._numeratore;
                }
                else if (frazione._numeratore > 0 && frazione._denominatore < 0)
                {
                    frazione._denominatore = -frazione._denominatore;
                }
                else if (frazione._numeratore < 0 && frazione._denominatore < 0)
                {
                    frazione._denominatore = -frazione._denominatore;
                    frazione._numeratore = -frazione._numeratore;
                }
            }
            else
            {
                Num.Text = " ";
                Den.Text = " ";

            }

            return giusto;
        }

        private void piu_Click(object sender, EventArgs e)
        {
            if (Inserimento())
                MessageBox.Show("La somma è " + frazione.Somma());
        }

        private void meno_Click(object sender, EventArgs e)
        {
            if (Inserimento())
                MessageBox.Show("La differenza è " + frazione.Differenza());
        }

        private void prodotto_Click(object sender, EventArgs e)
        {
            if (Inserimento())
                MessageBox.Show("Il prodotto è " + frazione.Moltiplicazione());
        }
        private void Semplifica_Click_1(object sender, EventArgs e)
        {
            if (Inserimento())
            {
                frazione.Semplifica();
                Num.Text = frazione._numeratore.ToString();
                Den.Text = frazione._denominatore.ToString();
            }
        }

        private void divisione_Click_1(object sender, EventArgs e)
        {
            if (Inserimento())
                MessageBox.Show("Il quoziente è " + frazione.Divisione());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Inserimento())
                MessageBox.Show("Il valore decimale è " + frazione.Divisione());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inserimento();
            for (int i = 1; i < Convert.ToInt16(textBox1.Text); i++)
            {
                frazione._numeratore = frazione._numeratore * frazione._numeratore;
            }
            for (int i = 1; i < Convert.ToInt16(textBox1.Text); i++)
            {
                frazione._denominatore = frazione._denominatore * frazione._denominatore;
            }
            Den.Text = frazione._denominatore.ToString();
            Num.Text = frazione._numeratore.ToString();
        }
    }
    class Frazione
    {
        public float _numeratore { get; set; }
        public float _denominatore { get; set; }
        public float _minore { get; set; }
        public void TrovaMinore()
        {
            if (_numeratore > _denominatore)
            {
                _minore = _denominatore;
            }
            else
            {
                _minore = _numeratore;
            }
        }
        public void Semplifica()
        {
            TrovaMinore();
            for (int i = 2; i <= _minore; i++)
            {
                if (_numeratore % i == 0 && _denominatore % i == 0)
                {
                    _numeratore = _numeratore / i;
                    _denominatore = _denominatore / i;
                    i = 1;
                }
            }
        }

        public float Somma()
        {
            return _numeratore + _denominatore;
        }

        public float Differenza()
        {
            return _numeratore - _denominatore;
        }
        public float Moltiplicazione()
        {
            return _numeratore * _denominatore;
        }
        public float Divisione()
        {
            return _numeratore / _denominatore;
        }
    }
}
