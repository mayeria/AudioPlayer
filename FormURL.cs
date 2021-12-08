using AudioPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPlayerSerwatko
{
    public partial class FormURL : Form
    {
        public FormURL()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form f1 = System.Windows.Forms.Application.OpenForms["Form1"];

        private void buttonWyszukaj_Click(object sender, EventArgs e)
        {
            try
            {
                ((Form1)f1).utwor = textBoxUrl.Text;
                ((Form1)f1).toolStripStatusLabelName.Text = Path.GetFileName(((Form1)f1).utwor);
                if (((Form1)f1).playlista)
                {
                    ((Form1)f1).listBoxPlaylista.Items.Add(((Form1)f1).toolStripStatusLabelName.Text);
                    ((Form1)f1).plikiPlaylista.Add(((Form1)f1).utwor);
                    ((Form1)f1).tabControlOdtwarzanie.SelectedIndex = 1;
                    ((Form1)f1).playlistChanged();
                }
                else
                    ((Form1)f1).buttonStart.PerformClick();
                ((Form1)f1).playlista = false;
                this.Close();
            }
            catch 
            { 
                textBoxUrl.Clear();
            }
        }
    }
}
