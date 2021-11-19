using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ini_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeesBestand_Click(object sender, EventArgs e)
        {
            string tekstfile = File.ReadAllText(@"C:\Users\Sebastiaan\Documents\School\Leerjaar 3\C#\instellingen.ini");
            labelTekstbestand.Text = tekstfile;

            // splits de string in twee regels
            string[] regels = tekstfile.Split('\n');
            Debug.Write(regels[0]);
            // voorgrondkleur=255,240,40
            // regels[0].Replace(" ", 
            regels[0] = regels[0].Substring(regels[0].IndexOf("=")+1);
            Debug.Write(regels[0]);
            int[] rgb = regels[0].Split(',').Select(Int32.Parse).ToArray();

            //regel 2
            Debug.Write(regels[1]);
            // string splitsen en naar int converteren
            regels[1] = regels[1].Substring(regels[1].IndexOf("=")+1);
            Debug.Write(regels[1]);
            int[] rgb1 = regels[1].Split(',').Select(Int32.Parse).ToArray();

            // tekstregel omzetten naar rgb
            //

            // label instellen met rgb waarden
            labelTekstbestand.ForeColor = Color.FromArgb(rgb[0], rgb[1], rgb[2]);

            //form kleur instellen
            this.BackColor = Color.FromArgb(rgb1[0], rgb1[1], rgb1[2]);
        }

        // er moet een ini bestand ingelezen worden

        // daar moet een achtergrondkleur en een voorgrondkleur in

        // deze moeten toegepast worden op het formulier

        // to do
        // eerste regel uitlezen
        // tweede regel uitlezen
        //aanpassen in het form
        // https://stackoverflow.com/questions/2891686/set-form-backcolor-to-custom-color
    }
}
