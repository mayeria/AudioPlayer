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
    public partial class FormSystemPlikow : Form
    {
        public FormSystemPlikow()
        {
            InitializeComponent();
        }

        string[] plikiSystem;
        System.Windows.Forms.Form f1 = System.Windows.Forms.Application.OpenForms["Form1"];

        private void listBoxFoldery_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                plikiSystem = Directory.GetFiles(listBoxFoldery.SelectedItem.ToString());
                listBoxPliki.Items.Clear();
                foreach (string name in plikiSystem)
                {
                    if (File.Exists(name))
                        listBoxPliki.Items.Add(name);
                }
                plikiSystem = Directory.GetDirectories(listBoxFoldery.SelectedItem.ToString());

                listBoxFoldery.Items.Clear();
                foreach (string name in plikiSystem)
                {
                    if (Directory.Exists(name))
                        listBoxFoldery.Items.Add(name);
                }
            }
            catch 
            {
                Exception ex = new Exception("Odmowa dostępu do folderu");
            }
        }

        private void listBoxPliki_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((Form1)f1).utwor = listBoxPliki.SelectedItem.ToString();
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
        }

        private void buttonWroc_Click(object sender, EventArgs e)
        {
            listBoxFoldery.Items.Clear();
            listBoxPliki.Items.Clear();

            plikiSystem = Directory.GetFiles(@"C:\");
            foreach (string name in plikiSystem)
            {
                if (File.Exists(name))
                    listBoxPliki.Items.Add(name);
            }
            plikiSystem = Directory.GetDirectories(@"C:\");
            foreach (string name in plikiSystem)
            {
                if (Directory.Exists(name))
                    listBoxFoldery.Items.Add(name);
            }
        }

        private void FormSystemPlikow_Load(object sender, EventArgs e)
        {
            buttonWroc.PerformClick();
        }
    }
}
