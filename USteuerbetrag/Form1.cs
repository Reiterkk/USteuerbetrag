using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USteuerbetrag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gehalt;
            double faktor;
            double steuerbetrag;
            bool isParsable = Int32.TryParse(TxtEingabe.Text, out gehalt);
            if (isParsable)
            {
                if (gehalt <= 12000)
                {
                    faktor = 0.12;
                }
                else if (gehalt <= 20000)
                {
                    faktor = 0.15;
                }
                else if (gehalt <= 30000)
                {
                    faktor = 0.20;
                }
                else
                {
                    faktor = 0.25;
                }
                steuerbetrag = gehalt * faktor;

                LblSteuerbetrag.Text = steuerbetrag.ToString();
            }

            else
                LblSteuerbetrag.Text = "Kein gültiges Gehalt angegeben!";
        }
    }
}
