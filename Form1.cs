using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace AudioPlayer
{
    public partial class Form1 : Form
    {
        private SoundPlayer player;
        bool async = true, playlista = false;
        string[] plikiSystem;
        string utwor;
        List<int> losowe = new List<int>(); List<string> plikiPlaylista = new List<string>();

        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
            player = new SoundPlayer();
            label2.Text = "Odtwarzanie asynchroniczne";
        }

        private void ButtonOdtworz_Click(object sender, EventArgs e)
        {
            if (panelOdtworz.Visible)
                panelOdtworz.Visible = false;
            else
                panelOdtworz.Visible = true;
            panelSystem.Visible = false; panelUrl.Visible = false; panelHistoria.Visible = false;
        }

        private void ButtonPlaylista_Click(object sender, EventArgs e)
        {
            panelHistoria.Visible = false; panelSystem.Visible = false; panelUrl.Visible = false;
            if (panelOdtworz.Visible)
                panelOdtworz.Visible = false;
            else
            {
                panelOdtworz.Visible = true;
                playlista = true;
            }
        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            panelOdtworz.Visible = false; panelSystem.Visible = false; panelUrl.Visible = false; panelHistoria.Visible = false;
            if (panelMenu.Visible)
                panelMenu.Visible = false;
            else
                panelMenu.Visible = true;
        }

        private void ListBoxPlaylista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPlaylista.SelectedItem != null)
            {
                utwor = plikiPlaylista[listBoxPlaylista.SelectedIndex];
                toolStripStatusLabel1.Text = Path.GetFileName(utwor);
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            try
            {
                player.SoundLocation = utwor;
                if (async)
                    player.Play();
                else
                    player.PlaySync();

                if (toolStripStatusLabel1.Text != "")
                {
                    listBoxHistoria.Items.Add(toolStripStatusLabel1.Text);
                    listBoxHistoria.SelectedIndex = listBoxHistoria.Items.Count - 1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd podczas odtwarzania");
            }
        }

        private void ButtonPetla_Click(object sender, EventArgs e)
        {
            player.SoundLocation = utwor;
            player.PlayLooping();
        }

        private void ButtonPoprzedni_Click(object sender, EventArgs e)
        {
            if(listBoxPlaylista.SelectedItem == null)
            {
                if (listBoxHistoria.SelectedIndex >= 1)
                {
                    listBoxHistoria.SelectedIndex--;
                    utwor = listBoxHistoria.SelectedItem.ToString();
                    toolStripStatusLabel1.Text = Path.GetFileName(utwor);
                    try
                    {
                        player.SoundLocation = utwor;
                        if (async)
                            player.Play();
                        else
                            player.PlaySync();
                        listBoxHistoria.Items.Add(toolStripStatusLabel1.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Błąd podczas odtwarzania");
                    }
                }
            }
            else
            {
                if (listBoxPlaylista.SelectedIndex > 0)
                {
                    listBoxPlaylista.SelectedIndex--;
                    buttonStart.PerformClick();
                }
                else
                {
                    listBoxPlaylista.SelectedIndex = 0;
                    buttonStart.PerformClick();
                }
            }
        }

        private void ButtonHistoria_Click(object sender, EventArgs e)
        {
            panelOdtworz.Visible = false; panelSystem.Visible = false; panelUrl.Visible = false;
            if (panelHistoria.Visible)
                panelHistoria.Visible = false;
            else
                panelHistoria.Visible = true;
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void ButtonNastepny_Click(object sender, EventArgs e)
        {
            if (listBoxPlaylista.SelectedItem != null && listBoxPlaylista.SelectedIndex != listBoxPlaylista.Items.Count - 1)
            {
                listBoxPlaylista.SelectedIndex++;
                buttonStart.PerformClick();
            }
        }

        private void ButtonSyncAsync_Click(object sender, EventArgs e)
        {
            if(buttonSyncAsync.Text == "Odtwórz synchronicznie")
            {
                buttonSyncAsync.Text = "Odtwórz asynchronicznie";
                async = false;
                label2.Text = "Odtwarzanie synchroniczne";
            }
            else
            {
                buttonSyncAsync.Text = "Odtwórz synchronicznie";
                async = true;
                label2.Text = "Odtwarzanie asynchroniczne";
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            listBoxPlaylista.Items.Clear();
            plikiPlaylista.Clear();
        }

        private void ButtonUsun_Click(object sender, EventArgs e)
        {
            if (listBoxPlaylista.Items.Count > 0)
            {
                plikiPlaylista.RemoveAt(listBoxPlaylista.SelectedIndex);
                listBoxPlaylista.Items.Remove(listBoxPlaylista.SelectedItem);
            }
        }

        private void ButtonResetHistoria_Click(object sender, EventArgs e)
        {
            listBoxHistoria.Items.Clear();
        }

        private void ButtonFileDialog_Click(object sender, EventArgs e)
        {
            panelUrl.Visible = false; panelSystem.Visible = false; panelHistoria.Visible = false; panelMenu.Visible = false; panelOdtworz.Visible = false;
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    utwor = openFileDialog1.FileName;
                    toolStripStatusLabel1.Text = Path.GetFileName(utwor);
                    panelOdtworz.Visible = false;
                    if (playlista)
                    {
                        listBoxPlaylista.Items.Add(toolStripStatusLabel1.Text);
                        plikiPlaylista.Add(utwor);
                    }
                    else
                        buttonStart.PerformClick();
                    playlista = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd podczas ładowania pliku");
            }
        }

        private void ButtonSystem_Click(object sender, EventArgs e)
        {
            panelUrl.Visible = false; panelHistoria.Visible = false;
            if (panelSystem.Visible)
                panelSystem.Visible = false;
            else
            {
                panelSystem.Visible = true;
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
        }

        private void ListBoxFoldery_SelectedIndexChanged(object sender, EventArgs e)
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

        private void ListBoxPliki_SelectedIndexChanged(object sender, EventArgs e)
        {
            utwor = listBoxPliki.SelectedItem.ToString();
            toolStripStatusLabel1.Text = Path.GetFileName(utwor);
            if (playlista)
            {
                listBoxPlaylista.Items.Add(toolStripStatusLabel1.Text);
                plikiPlaylista.Add(utwor);
            }
            else
                buttonStart.PerformClick();
            playlista = false;
        }

        private void ButtonWyszukaj_Click(object sender, EventArgs e)
        {
            utwor = textBoxUrl.Text;
            toolStripStatusLabel1.Text = Path.GetFileName(utwor);
            if (playlista)
            {
                listBoxPlaylista.Items.Add(toolStripStatusLabel1.Text);
                plikiPlaylista.Add(utwor);
            }
            else
                buttonStart.PerformClick();
            playlista = false;
        }

        private void ButtonLosowo_Click(object sender, EventArgs e)
        {
            if (listBoxPlaylista.Items.Count > 0)
            {
                var rand = new Random();
                if (losowe.Count == 0)
                    losowe = Enumerable.Range(0, listBoxPlaylista.Items.Count).ToList();
                int index = rand.Next(0, losowe.Count);
                listBoxPlaylista.SelectedIndex = losowe[index];
                losowe.RemoveAt(index);
                buttonStart.PerformClick();
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            listBoxPlaylista.ClearSelected();
        }

        private void ButtonUrl_Click(object sender, EventArgs e)
        {
            if (panelUrl.Visible)
                panelUrl.Visible = false;
            else
                panelUrl.Visible = true;
            panelSystem.Visible = false; panelHistoria.Visible = false;
        }
    }
}
