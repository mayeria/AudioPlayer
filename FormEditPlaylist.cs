using AudioPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPlayerSerwatko
{
    public partial class FormEditPlaylist : Form
    {
        public FormEditPlaylist()
        {
            InitializeComponent();
            for (int i = 0; i < ((Form1)f1).listBoxPlaylista.Items.Count; i++)
            {
                Column1.Items.Add(i.ToString());
                dataGridView1.Rows.Add(Column1.Items[i], ((Form1)f1).listBoxPlaylista.Items[i]);
            }
        }

        List<string> plikiPlaylista = new List<string>();

        System.Windows.Forms.Form f1 = System.Windows.Forms.Application.OpenForms["Form1"];

        private void buttonOK_Click(object sender, EventArgs e)
        {
            foreach(string s in ((Form1)f1).plikiPlaylista)
                plikiPlaylista.Add(s);
            ((Form1)f1).listBoxPlaylista.Items.Clear();
            ((Form1)f1).plikiPlaylista.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ((Form1)f1).listBoxPlaylista.Items.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                foreach (string song in plikiPlaylista)
                {
                    if(song.Contains(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                        ((Form1)f1).plikiPlaylista.Add(song);
                }
                
            }
            ((Form1)f1).playlistChanged();
            if(((Form1)f1).outputDevice != null)
                ((Form1)f1).outputDevice.Dispose();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
