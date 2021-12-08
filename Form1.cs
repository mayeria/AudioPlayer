using AudioPlayerSerwatko;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using NAudio.Wave;
using System.Drawing;
using Spectrogram;

namespace AudioPlayer
{
    public partial class Form1 : Form
    {
        public bool playlista = false, mouseDown = false, loop = false, loopPlaylist = false, shuffle = false, last = false, stop = false, next = false, prev = false, click = false;

        public WaveOutEvent outputDevice;
        private AudioFileReader audioFile, playlistTime, remainingAudioFile;

        int totalPlaylist, remaining, trackbarvalue1, trackbarvalue2;

        public string utwor;
        List<int> losowe = new List<int>(); public List<string> plikiPlaylista = new List<string>();

        SpectrogramGenerator sg;

        System.Windows.Forms.Form fu = System.Windows.Forms.Application.OpenForms["FormURL"];
        System.Windows.Forms.Form fs = System.Windows.Forms.Application.OpenForms["FormSystemPlikow"];
        System.Windows.Forms.Form fe = System.Windows.Forms.Application.OpenForms["FormEditPlaylist"];

        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabelName.Text = "";
            this.FormClosing += ButtonStop_Click;
        }

        private void ListBoxPlaylista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPlaylista.SelectedItem != null && click)
            {
                trackBar1.Value = 0;
                if (outputDevice != null)
                {
                    outputDevice.Dispose();
                    outputDevice = null;
                    audioFile.Dispose();
                    audioFile = null;
                    timer1.Stop();
                }
                utwor = plikiPlaylista[listBoxPlaylista.SelectedIndex];
                toolStripStatusLabelName.Text = Path.GetFileName(utwor);
                buttonStart.PerformClick();
                click = false;
            }
        }

        private void listBoxPlaylista_Click(object sender, EventArgs e)
        {
            if (listBoxPlaylista.SelectedItem != null)
            {
                click = true;
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (utwor != null)
                {
                    stop = false;
                    if (listBoxPlaylista.Items.Count != 0 && listBoxPlaylista.SelectedItem == null)
                        listBoxPlaylista.SelectedIndex = 0;
                    if (outputDevice == null)
                    {
                        outputDevice = new WaveOutEvent();
                        outputDevice.PlaybackStopped += PlaybackStopped;
                    }
                    if (audioFile == null)
                    {
                        audioFile = new AudioFileReader(utwor);
                        outputDevice.Init(audioFile);
                    }
                    if (buttonStart.Text == "▶️")
                    {
                        buttonStart.Text = "||";
                        pictureBox1.Image = null;
                        outputDevice.Play();
                        labelTotalTime.Text = audioFile.TotalTime.ToString(@"m\:ss");
                        toolStripStatusLabelDuration.Text = labelTotalTime.Text;
                        timer1.Start();
                        trackBar1.Maximum = Convert.ToInt32(audioFile.TotalTime.TotalMilliseconds);

                        if (toolStripStatusLabelName.Text != "")
                        {
                            listBoxHistoria.Items.Add(toolStripStatusLabelName.Text);
                            listBoxHistoria.SelectedIndex = listBoxHistoria.Items.Count - 1;
                        }

                        var tagFile = TagLib.File.Create(utwor);
                        labelName.Text = tagFile.Tag.FirstPerformer + " - " + tagFile.Tag.Title;
                        double length = new System.IO.FileInfo(utwor).Length * 0.000001;
                        toolStripStatusLabelSize.Text = string.Format("{0:0.0}", Math.Truncate(length * 10) / 10) + "MB";
                        toolStripStatusLabelAlbum.Text = tagFile.Tag.Album;
                        toolStripStatusLabelGenre.Text = tagFile.Tag.FirstGenre;

                        try
                        {
                            MemoryStream ms = new MemoryStream(tagFile.Tag.Pictures[0].Data.Data);
                            System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                            pictureBox1.Image = image;
                        }
                        catch { }

                        try
                        {
                            waveViewer1.WaveStream = new NAudio.Wave.WaveFileReader(utwor);
                        }
                        catch { }
                    }
                    else
                    {
                        buttonStart.Text = "▶️";
                        outputDevice.Pause();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd podczas odtwarzania");
            }
        }

        private void PlaybackStopped(object sender, StoppedEventArgs args)
        {
            buttonStart.Text = "▶️";
            if (!prev && !next && !click)
            {
                trackBar1.Value = 0;
                outputDevice.Dispose();
                outputDevice = null;
                audioFile.Dispose();
                audioFile = null;
                timer1.Stop();
                if (!stop)
                {
                    if (listBoxPlaylista.Items != null && listBoxPlaylista.SelectedIndex != listBoxPlaylista.Items.Count - 1 && !shuffle && !loop)
                    {
                        listBoxPlaylista.SelectedIndex += 1;
                        buttonStart.PerformClick();
                    }
                    if (loop)
                        buttonStart.PerformClick();
                    if (loopPlaylist)
                    {
                        if (listBoxPlaylista.SelectedIndex == listBoxPlaylista.Items.Count - 1)
                        {
                            if (last)
                            {
                                listBoxPlaylista.SelectedIndex = 0;
                                buttonStart.PerformClick();
                                Remaining();
                                last = false;
                            }
                            else
                            {
                                last = true;
                            }

                        }
                    }
                    if (shuffle && !loop)
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
            }
            prev = false; next = false;
        }

        private void ButtonPetla_Click(object sender, EventArgs e)
        {
            if (buttonPetla.Text == "🔂" && buttonPetla.ForeColor == Color.DarkGray)
            {
                loop = true;
                buttonPetla.ForeColor = Color.RoyalBlue;
            }
            else if (buttonPetla.Text == "🔁")
            {
                loopPlaylist = false;
                buttonPetla.ForeColor = Color.DarkGray;
                buttonPetla.Text = "🔂";
                labelPlaylistRemaining.Text = "";
                label2.Text = "";
            }
            else
            {
                loop = false;
                loopPlaylist = true;
                buttonPetla.Text = "🔁";
                remaining = totalPlaylist;
                label2.Text = "-";
            }
        }

        private void ButtonPoprzedni_Click(object sender, EventArgs e)
        {
            prev = true;
            trackBar1.Value = 0;
            if (outputDevice != null && audioFile != null)
            {
                outputDevice.Dispose();
                outputDevice = null;
                audioFile.Dispose();
                audioFile = null;
                timer1.Stop();
            }
                if (listBoxPlaylista.SelectedItem == null)
                {
                    if (listBoxHistoria.SelectedIndex >= 1)
                    {
                        listBoxHistoria.SelectedIndex--;
                        utwor = listBoxHistoria.SelectedItem.ToString();
                        toolStripStatusLabelName.Text = Path.GetFileName(utwor);
                        try
                        {
                            buttonStart.PerformClick();
                            listBoxHistoria.Items.Add(toolStripStatusLabelName.Text);
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

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
            stop = true;
        }

        private void ButtonNastepny_Click(object sender, EventArgs e)
        {
            next = true;
            trackBar1.Value = 0;
            if (outputDevice != null)
            {
                outputDevice.Dispose();
                outputDevice = null;
                audioFile.Dispose();
                audioFile = null;
            }
            if (listBoxPlaylista.SelectedItem != null && listBoxPlaylista.SelectedIndex != listBoxPlaylista.Items.Count - 1)
            {
                timer1.Stop();
                listBoxPlaylista.SelectedIndex++;
                buttonStart.PerformClick();
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

        private void ButtonLosowo_Click(object sender, EventArgs e)
        {
            if (shuffle)
            {
                buttonLosowo.ForeColor = Color.DarkGray;
                shuffle = false;
            }
            else
            {
                buttonLosowo.ForeColor = Color.RoyalBlue;
                shuffle = true;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            listBoxPlaylista.ClearSelected();
        }

        private void openFileDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    utwor = openFileDialog1.FileName;
                    toolStripStatusLabelName.Text = Path.GetFileName(utwor);
                    if (playlista)
                    {
                        listBoxPlaylista.Items.Add(toolStripStatusLabelName.Text);
                        plikiPlaylista.Add(utwor);
                        tabControlOdtwarzanie.SelectedIndex = 1;
                        playlistChanged();
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

        private void zURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fu = new FormURL();
            fu.Show();
        }

        private void zOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playlista = true;
            openFileDialogToolStripMenuItem.PerformClick();
        }

        private void zURLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            playlista = true;
            zURLToolStripMenuItem.PerformClick();
        }

        private void zSystemuPlikówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fs = new FormSystemPlikow();
            fs.Show();
        }

        private void buttonSpectrogram_Click(object sender, EventArgs e)
        {
            (double[] audio, int sampleRate) = ReadWavMono(utwor);
            var sg = new SpectrogramGenerator(sampleRate, fftSize: 4096, stepSize: 500, maxFreq: 3000);
            sg.Add(audio);
            Bitmap bmp = sg.GetBitmapMel(250);
            pictureBox2.Image = sg.GetBitmap();
        }

        private void zSystemuPlikówToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            playlista = true;
            zSystemuPlikówToolStripMenuItem.PerformClick();
        }

        private void buttonRewind_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.Skip(-5);
            }
        }

        private void buttonEditPlaylist_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (outputDevice != null)
                outputDevice.Pause();
            fe = new FormEditPlaylist();
            fe.Show();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.Skip(5);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                labelCurrentTime.Text = TimeSpan.FromMilliseconds(trackBar1.Value).ToString(@"m\:ss");
                trackBar1.Value = audioFile.CurrentTime.Milliseconds;
                int value = (int)audioFile.CurrentTime.TotalMilliseconds;
                trackBar1.Value = (value > trackBar1.Maximum) ? trackBar1.Maximum : value;
                if (loopPlaylist)
                {
                    remaining -= 1000;
                    labelPlaylistRemaining.Text = TimeSpan.FromMilliseconds(remaining).ToString(@"m\:ss");
                }
            }
        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            if (outputDevice != null)
            {
                trackbarvalue1 = trackBar1.Value;
                timer1.Stop();
                outputDevice.Pause();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelCurrentTime.Left = trackBar1.Location.X + (trackBar1.Width - 28) * trackBar1.Value / trackBar1.Maximum;
            labelCurrentTime.Text = TimeSpan.FromMilliseconds(trackBar1.Value).ToString(@"m\:ss");
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            if (outputDevice != null)
            {
                trackbarvalue2 = trackBar1.Value;
                timer1.Start();
                audioFile.Position = trackBar1.Value / 1000 * outputDevice.OutputWaveFormat.AverageBytesPerSecond;
                if(buttonStart.Text == "||")
                    outputDevice.Play();
                labelCurrentTime.Left = 22;
                remaining += trackbarvalue1 - trackbarvalue2;
            }
        }

        public void playlistChanged()
        {
            if (plikiPlaylista != null)
            {
                totalPlaylist = 0;
                foreach (string song in plikiPlaylista)
                {
                    playlistTime = new AudioFileReader(song);
                    totalPlaylist += (int)playlistTime.TotalTime.TotalMilliseconds;
                    labelPlaylista.Text = TimeSpan.FromMilliseconds(totalPlaylist).ToString(@"m\:ss");
                }
            }
        }

        private void Remaining()
        {
            remaining = 0;
            for (int i = listBoxPlaylista.SelectedIndex; i <= listBoxPlaylista.Items.Count-1; i++)
            {
                remainingAudioFile = new AudioFileReader(plikiPlaylista[i]);
                remaining += (int)remainingAudioFile.TotalTime.TotalMilliseconds;
            }
        }

        (double[] audio, int sampleRate) ReadWavMono(string filePath, double multiplier = 16_000)
        {
            var afr = new NAudio.Wave.AudioFileReader(filePath);
            int sampleRate = afr.WaveFormat.SampleRate;
            int bytesPerSample = afr.WaveFormat.BitsPerSample / 8;
            int sampleCount = (int)(afr.Length / bytesPerSample);
            int channelCount = afr.WaveFormat.Channels;
            var audio = new List<double>(sampleCount);
            var buffer = new float[sampleRate * channelCount];
            int samplesRead = 0;
            while ((samplesRead = afr.Read(buffer, 0, buffer.Length)) > 0)
                audio.AddRange(buffer.Take(samplesRead).Select(x => x * multiplier));
            return (audio.ToArray(), sampleRate);
        }
    }
}
