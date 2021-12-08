namespace AudioPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelOdtwarzania = new System.Windows.Forms.Panel();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonRewind = new System.Windows.Forms.Button();
            this.buttonLosowo = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPetla = new System.Windows.Forms.Button();
            this.buttonNastepny = new System.Windows.Forms.Button();
            this.buttonPoprzedni = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDuration = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAlbum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelGenre = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonResetHistoria = new System.Windows.Forms.Button();
            this.listBoxHistoria = new System.Windows.Forms.ListBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.tabControlOdtwarzanie = new System.Windows.Forms.TabControl();
            this.tabPageOdtwarzanie = new System.Windows.Forms.TabPage();
            this.labelName = new System.Windows.Forms.Label();
            this.tabControlSong = new System.Windows.Forms.TabControl();
            this.tabPageImage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageWaveform = new System.Windows.Forms.TabPage();
            this.waveViewer1 = new NAudio.Gui.WaveViewer();
            this.tabPageSpectrogram = new System.Windows.Forms.TabPage();
            this.buttonSpectrogram = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPagePlaylista = new System.Windows.Forms.TabPage();
            this.listBoxPlaylista = new System.Windows.Forms.ListBox();
            this.buttonEditPlaylist = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPlaylistRemaining = new System.Windows.Forms.Label();
            this.labelPlaylista = new System.Windows.Forms.Label();
            this.tabPageHistoria = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odtwórzPlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zSystemuPlikówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajDoPlaylistyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zURLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zSystemuPlikówToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panelOdtwarzania.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControlOdtwarzanie.SuspendLayout();
            this.tabPageOdtwarzanie.SuspendLayout();
            this.tabControlSong.SuspendLayout();
            this.tabPageImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageWaveform.SuspendLayout();
            this.tabPageSpectrogram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPagePlaylista.SuspendLayout();
            this.tabPageHistoria.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOdtwarzania
            // 
            this.panelOdtwarzania.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelOdtwarzania.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelOdtwarzania.Controls.Add(this.buttonForward);
            this.panelOdtwarzania.Controls.Add(this.buttonRewind);
            this.panelOdtwarzania.Controls.Add(this.buttonLosowo);
            this.panelOdtwarzania.Controls.Add(this.buttonStop);
            this.panelOdtwarzania.Controls.Add(this.buttonPetla);
            this.panelOdtwarzania.Controls.Add(this.buttonNastepny);
            this.panelOdtwarzania.Controls.Add(this.buttonPoprzedni);
            this.panelOdtwarzania.Controls.Add(this.buttonStart);
            this.panelOdtwarzania.Location = new System.Drawing.Point(0, 427);
            this.panelOdtwarzania.Name = "panelOdtwarzania";
            this.panelOdtwarzania.Size = new System.Drawing.Size(573, 76);
            this.panelOdtwarzania.TabIndex = 0;
            // 
            // buttonForward
            // 
            this.buttonForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonForward.Location = new System.Drawing.Point(336, 11);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(39, 33);
            this.buttonForward.TabIndex = 8;
            this.buttonForward.Text = "⏩";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonRewind
            // 
            this.buttonRewind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRewind.Location = new System.Drawing.Point(184, 13);
            this.buttonRewind.Name = "buttonRewind";
            this.buttonRewind.Size = new System.Drawing.Size(39, 33);
            this.buttonRewind.TabIndex = 7;
            this.buttonRewind.Text = "⏪";
            this.buttonRewind.UseVisualStyleBackColor = true;
            this.buttonRewind.Click += new System.EventHandler(this.buttonRewind_Click);
            // 
            // buttonLosowo
            // 
            this.buttonLosowo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLosowo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLosowo.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonLosowo.Location = new System.Drawing.Point(32, 3);
            this.buttonLosowo.Name = "buttonLosowo";
            this.buttonLosowo.Size = new System.Drawing.Size(44, 46);
            this.buttonLosowo.TabIndex = 6;
            this.buttonLosowo.Text = "🔀";
            this.buttonLosowo.UseVisualStyleBackColor = false;
            this.buttonLosowo.Click += new System.EventHandler(this.ButtonLosowo_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStop.Location = new System.Drawing.Point(284, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(46, 43);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "⬛";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // buttonPetla
            // 
            this.buttonPetla.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPetla.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPetla.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonPetla.Location = new System.Drawing.Point(484, 3);
            this.buttonPetla.Name = "buttonPetla";
            this.buttonPetla.Size = new System.Drawing.Size(50, 48);
            this.buttonPetla.TabIndex = 4;
            this.buttonPetla.Text = "🔂";
            this.buttonPetla.UseVisualStyleBackColor = false;
            this.buttonPetla.Click += new System.EventHandler(this.ButtonPetla_Click);
            // 
            // buttonNastepny
            // 
            this.buttonNastepny.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNastepny.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNastepny.Location = new System.Drawing.Point(414, 14);
            this.buttonNastepny.Name = "buttonNastepny";
            this.buttonNastepny.Size = new System.Drawing.Size(38, 35);
            this.buttonNastepny.TabIndex = 3;
            this.buttonNastepny.Text = "⏭️";
            this.buttonNastepny.UseVisualStyleBackColor = false;
            this.buttonNastepny.Click += new System.EventHandler(this.ButtonNastepny_Click);
            // 
            // buttonPoprzedni
            // 
            this.buttonPoprzedni.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPoprzedni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPoprzedni.Location = new System.Drawing.Point(101, 13);
            this.buttonPoprzedni.Name = "buttonPoprzedni";
            this.buttonPoprzedni.Size = new System.Drawing.Size(36, 34);
            this.buttonPoprzedni.TabIndex = 2;
            this.buttonPoprzedni.Text = "⏮️";
            this.buttonPoprzedni.UseVisualStyleBackColor = false;
            this.buttonPoprzedni.Click += new System.EventHandler(this.ButtonPoprzedni_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(229, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(49, 43);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "▶️";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelName,
            this.toolStripStatusLabelDuration,
            this.toolStripStatusLabelSize,
            this.toolStripStatusLabelAlbum,
            this.toolStripStatusLabelGenre});
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(570, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelName
            // 
            this.toolStripStatusLabelName.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabelName.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabelName.Name = "toolStripStatusLabelName";
            this.toolStripStatusLabelName.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabelName.Text = "Name";
            // 
            // toolStripStatusLabelDuration
            // 
            this.toolStripStatusLabelDuration.Name = "toolStripStatusLabelDuration";
            this.toolStripStatusLabelDuration.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabelDuration.Text = "Duration";
            // 
            // toolStripStatusLabelSize
            // 
            this.toolStripStatusLabelSize.Name = "toolStripStatusLabelSize";
            this.toolStripStatusLabelSize.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatusLabelSize.Text = "Size";
            // 
            // toolStripStatusLabelAlbum
            // 
            this.toolStripStatusLabelAlbum.Name = "toolStripStatusLabelAlbum";
            this.toolStripStatusLabelAlbum.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabelAlbum.Text = "Album";
            // 
            // toolStripStatusLabelGenre
            // 
            this.toolStripStatusLabelGenre.Name = "toolStripStatusLabelGenre";
            this.toolStripStatusLabelGenre.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabelGenre.Text = "Genre";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Audio Files (*.wav, *.mp3 )|*.wav; *.mp3";
            this.openFileDialog1.Multiselect = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(182, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Audio Player";
            // 
            // buttonResetHistoria
            // 
            this.buttonResetHistoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonResetHistoria.Location = new System.Drawing.Point(433, 273);
            this.buttonResetHistoria.Name = "buttonResetHistoria";
            this.buttonResetHistoria.Size = new System.Drawing.Size(99, 23);
            this.buttonResetHistoria.TabIndex = 1;
            this.buttonResetHistoria.Text = "Wyczyść historię";
            this.buttonResetHistoria.UseVisualStyleBackColor = false;
            this.buttonResetHistoria.Click += new System.EventHandler(this.ButtonResetHistoria_Click);
            // 
            // listBoxHistoria
            // 
            this.listBoxHistoria.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBoxHistoria.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxHistoria.FormattingEnabled = true;
            this.listBoxHistoria.Location = new System.Drawing.Point(3, 3);
            this.listBoxHistoria.Name = "listBoxHistoria";
            this.listBoxHistoria.Size = new System.Drawing.Size(529, 264);
            this.listBoxHistoria.TabIndex = 0;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonReset.Location = new System.Drawing.Point(422, 312);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(101, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Wyczyść playlistę";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // tabControlOdtwarzanie
            // 
            this.tabControlOdtwarzanie.Controls.Add(this.tabPageOdtwarzanie);
            this.tabControlOdtwarzanie.Controls.Add(this.tabPagePlaylista);
            this.tabControlOdtwarzanie.Controls.Add(this.tabPageHistoria);
            this.tabControlOdtwarzanie.HotTrack = true;
            this.tabControlOdtwarzanie.Location = new System.Drawing.Point(12, 55);
            this.tabControlOdtwarzanie.Multiline = true;
            this.tabControlOdtwarzanie.Name = "tabControlOdtwarzanie";
            this.tabControlOdtwarzanie.SelectedIndex = 0;
            this.tabControlOdtwarzanie.Size = new System.Drawing.Size(546, 328);
            this.tabControlOdtwarzanie.TabIndex = 11;
            // 
            // tabPageOdtwarzanie
            // 
            this.tabPageOdtwarzanie.BackColor = System.Drawing.Color.Black;
            this.tabPageOdtwarzanie.Controls.Add(this.labelName);
            this.tabPageOdtwarzanie.Controls.Add(this.tabControlSong);
            this.tabPageOdtwarzanie.Location = new System.Drawing.Point(4, 22);
            this.tabPageOdtwarzanie.Name = "tabPageOdtwarzanie";
            this.tabPageOdtwarzanie.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOdtwarzanie.Size = new System.Drawing.Size(538, 302);
            this.tabPageOdtwarzanie.TabIndex = 0;
            this.tabPageOdtwarzanie.Text = "Odtwarzanie";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelName.Location = new System.Drawing.Point(6, 276);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(526, 23);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Song Title";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlSong
            // 
            this.tabControlSong.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlSong.Controls.Add(this.tabPageImage);
            this.tabControlSong.Controls.Add(this.tabPageWaveform);
            this.tabControlSong.Controls.Add(this.tabPageSpectrogram);
            this.tabControlSong.Location = new System.Drawing.Point(6, 6);
            this.tabControlSong.Multiline = true;
            this.tabControlSong.Name = "tabControlSong";
            this.tabControlSong.SelectedIndex = 0;
            this.tabControlSong.Size = new System.Drawing.Size(526, 267);
            this.tabControlSong.TabIndex = 2;
            // 
            // tabPageImage
            // 
            this.tabPageImage.BackColor = System.Drawing.Color.Black;
            this.tabPageImage.Controls.Add(this.pictureBox1);
            this.tabPageImage.Location = new System.Drawing.Point(4, 4);
            this.tabPageImage.Name = "tabPageImage";
            this.tabPageImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImage.Size = new System.Drawing.Size(518, 241);
            this.tabPageImage.TabIndex = 0;
            this.tabPageImage.Text = "Utwór";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPageWaveform
            // 
            this.tabPageWaveform.AutoScroll = true;
            this.tabPageWaveform.BackColor = System.Drawing.Color.Black;
            this.tabPageWaveform.Controls.Add(this.waveViewer1);
            this.tabPageWaveform.Location = new System.Drawing.Point(4, 4);
            this.tabPageWaveform.Name = "tabPageWaveform";
            this.tabPageWaveform.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWaveform.Size = new System.Drawing.Size(518, 241);
            this.tabPageWaveform.TabIndex = 1;
            this.tabPageWaveform.Text = "Przebieg fali";
            // 
            // waveViewer1
            // 
            this.waveViewer1.AutoScroll = true;
            this.waveViewer1.AutoSize = true;
            this.waveViewer1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.waveViewer1.Location = new System.Drawing.Point(3, 3);
            this.waveViewer1.Name = "waveViewer1";
            this.waveViewer1.SamplesPerPixel = 6100;
            this.waveViewer1.Size = new System.Drawing.Size(1212, 215);
            this.waveViewer1.StartPosition = ((long)(0));
            this.waveViewer1.TabIndex = 0;
            this.waveViewer1.WaveStream = null;
            // 
            // tabPageSpectrogram
            // 
            this.tabPageSpectrogram.BackColor = System.Drawing.Color.Black;
            this.tabPageSpectrogram.Controls.Add(this.buttonSpectrogram);
            this.tabPageSpectrogram.Controls.Add(this.pictureBox2);
            this.tabPageSpectrogram.Location = new System.Drawing.Point(4, 4);
            this.tabPageSpectrogram.Name = "tabPageSpectrogram";
            this.tabPageSpectrogram.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpectrogram.Size = new System.Drawing.Size(518, 241);
            this.tabPageSpectrogram.TabIndex = 2;
            this.tabPageSpectrogram.Text = "Spektrogram";
            // 
            // buttonSpectrogram
            // 
            this.buttonSpectrogram.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonSpectrogram.Location = new System.Drawing.Point(196, 6);
            this.buttonSpectrogram.Name = "buttonSpectrogram";
            this.buttonSpectrogram.Size = new System.Drawing.Size(132, 23);
            this.buttonSpectrogram.TabIndex = 1;
            this.buttonSpectrogram.Text = "Generuj spektrogram";
            this.buttonSpectrogram.UseVisualStyleBackColor = false;
            this.buttonSpectrogram.Click += new System.EventHandler(this.buttonSpectrogram_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(6, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(506, 203);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabPagePlaylista
            // 
            this.tabPagePlaylista.BackColor = System.Drawing.Color.Black;
            this.tabPagePlaylista.Controls.Add(this.listBoxPlaylista);
            this.tabPagePlaylista.Controls.Add(this.buttonEditPlaylist);
            this.tabPagePlaylista.Controls.Add(this.label2);
            this.tabPagePlaylista.Controls.Add(this.labelPlaylistRemaining);
            this.tabPagePlaylista.Controls.Add(this.labelPlaylista);
            this.tabPagePlaylista.Controls.Add(this.buttonReset);
            this.tabPagePlaylista.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlaylista.Name = "tabPagePlaylista";
            this.tabPagePlaylista.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlaylista.Size = new System.Drawing.Size(538, 302);
            this.tabPagePlaylista.TabIndex = 1;
            this.tabPagePlaylista.Text = "Playlista";
            // 
            // listBoxPlaylista
            // 
            this.listBoxPlaylista.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBoxPlaylista.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxPlaylista.FormattingEnabled = true;
            this.listBoxPlaylista.Location = new System.Drawing.Point(3, 4);
            this.listBoxPlaylista.Name = "listBoxPlaylista";
            this.listBoxPlaylista.Size = new System.Drawing.Size(532, 264);
            this.listBoxPlaylista.TabIndex = 12;
            this.listBoxPlaylista.Click += new System.EventHandler(this.listBoxPlaylista_Click);
            this.listBoxPlaylista.SelectedIndexChanged += new System.EventHandler(this.ListBoxPlaylista_SelectedIndexChanged);
            // 
            // buttonEditPlaylist
            // 
            this.buttonEditPlaylist.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonEditPlaylist.Location = new System.Drawing.Point(448, 273);
            this.buttonEditPlaylist.Name = "buttonEditPlaylist";
            this.buttonEditPlaylist.Size = new System.Drawing.Size(75, 23);
            this.buttonEditPlaylist.TabIndex = 11;
            this.buttonEditPlaylist.Text = "Edytuj";
            this.buttonEditPlaylist.UseVisualStyleBackColor = false;
            this.buttonEditPlaylist.Click += new System.EventHandler(this.buttonEditPlaylist_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(69, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // labelPlaylistRemaining
            // 
            this.labelPlaylistRemaining.AutoSize = true;
            this.labelPlaylistRemaining.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPlaylistRemaining.Location = new System.Drawing.Point(117, 283);
            this.labelPlaylistRemaining.Name = "labelPlaylistRemaining";
            this.labelPlaylistRemaining.Size = new System.Drawing.Size(0, 13);
            this.labelPlaylistRemaining.TabIndex = 9;
            // 
            // labelPlaylista
            // 
            this.labelPlaylista.AutoSize = true;
            this.labelPlaylista.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPlaylista.Location = new System.Drawing.Point(6, 283);
            this.labelPlaylista.Name = "labelPlaylista";
            this.labelPlaylista.Size = new System.Drawing.Size(0, 13);
            this.labelPlaylista.TabIndex = 8;
            // 
            // tabPageHistoria
            // 
            this.tabPageHistoria.BackColor = System.Drawing.Color.Black;
            this.tabPageHistoria.Controls.Add(this.buttonResetHistoria);
            this.tabPageHistoria.Controls.Add(this.listBoxHistoria);
            this.tabPageHistoria.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistoria.Name = "tabPageHistoria";
            this.tabPageHistoria.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistoria.Size = new System.Drawing.Size(538, 302);
            this.tabPageHistoria.TabIndex = 2;
            this.tabPageHistoria.Text = "Historia";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odtwórzPlikToolStripMenuItem,
            this.dodajDoPlaylistyToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // odtwórzPlikToolStripMenuItem
            // 
            this.odtwórzPlikToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.odtwórzPlikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileDialogToolStripMenuItem,
            this.zURLToolStripMenuItem,
            this.zSystemuPlikówToolStripMenuItem});
            this.odtwórzPlikToolStripMenuItem.Name = "odtwórzPlikToolStripMenuItem";
            this.odtwórzPlikToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.odtwórzPlikToolStripMenuItem.Text = "Odtwórz plik";
            // 
            // openFileDialogToolStripMenuItem
            // 
            this.openFileDialogToolStripMenuItem.Name = "openFileDialogToolStripMenuItem";
            this.openFileDialogToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.openFileDialogToolStripMenuItem.Text = "OpenFileDialog";
            this.openFileDialogToolStripMenuItem.Click += new System.EventHandler(this.openFileDialogToolStripMenuItem_Click);
            // 
            // zURLToolStripMenuItem
            // 
            this.zURLToolStripMenuItem.Name = "zURLToolStripMenuItem";
            this.zURLToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.zURLToolStripMenuItem.Text = "Z URL";
            this.zURLToolStripMenuItem.Click += new System.EventHandler(this.zURLToolStripMenuItem_Click);
            // 
            // zSystemuPlikówToolStripMenuItem
            // 
            this.zSystemuPlikówToolStripMenuItem.Name = "zSystemuPlikówToolStripMenuItem";
            this.zSystemuPlikówToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.zSystemuPlikówToolStripMenuItem.Text = "Z systemu plików";
            this.zSystemuPlikówToolStripMenuItem.Click += new System.EventHandler(this.zSystemuPlikówToolStripMenuItem_Click);
            // 
            // dodajDoPlaylistyToolStripMenuItem
            // 
            this.dodajDoPlaylistyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zOToolStripMenuItem,
            this.zURLToolStripMenuItem1,
            this.zSystemuPlikówToolStripMenuItem1});
            this.dodajDoPlaylistyToolStripMenuItem.Name = "dodajDoPlaylistyToolStripMenuItem";
            this.dodajDoPlaylistyToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.dodajDoPlaylistyToolStripMenuItem.Text = "Dodaj do playlisty";
            // 
            // zOToolStripMenuItem
            // 
            this.zOToolStripMenuItem.Name = "zOToolStripMenuItem";
            this.zOToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.zOToolStripMenuItem.Text = "OpenFileDialog";
            this.zOToolStripMenuItem.Click += new System.EventHandler(this.zOToolStripMenuItem_Click);
            // 
            // zURLToolStripMenuItem1
            // 
            this.zURLToolStripMenuItem1.Name = "zURLToolStripMenuItem1";
            this.zURLToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.zURLToolStripMenuItem1.Text = "Z URL";
            this.zURLToolStripMenuItem1.Click += new System.EventHandler(this.zURLToolStripMenuItem1_Click);
            // 
            // zSystemuPlikówToolStripMenuItem1
            // 
            this.zSystemuPlikówToolStripMenuItem1.Name = "zSystemuPlikówToolStripMenuItem1";
            this.zSystemuPlikówToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.zSystemuPlikówToolStripMenuItem1.Text = "Z systemu plików";
            this.zSystemuPlikówToolStripMenuItem1.Click += new System.EventHandler(this.zSystemuPlikówToolStripMenuItem1_Click);
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCurrentTime.Location = new System.Drawing.Point(22, 410);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(0, 13);
            this.labelCurrentTime.TabIndex = 14;
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalTime.Location = new System.Drawing.Point(519, 408);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(0, 13);
            this.labelTotalTime.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(12, 389);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(546, 32);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(570, 522);
            this.Controls.Add(this.labelTotalTime);
            this.Controls.Add(this.labelCurrentTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelOdtwarzania);
            this.Controls.Add(this.tabControlOdtwarzanie);
            this.Controls.Add(this.trackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Audio Player";
            this.panelOdtwarzania.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControlOdtwarzanie.ResumeLayout(false);
            this.tabPageOdtwarzanie.ResumeLayout(false);
            this.tabControlSong.ResumeLayout(false);
            this.tabPageImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageWaveform.ResumeLayout(false);
            this.tabPageWaveform.PerformLayout();
            this.tabPageSpectrogram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPagePlaylista.ResumeLayout(false);
            this.tabPagePlaylista.PerformLayout();
            this.tabPageHistoria.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelOdtwarzania;
        private System.Windows.Forms.Button buttonPetla;
        private System.Windows.Forms.Button buttonNastepny;
        private System.Windows.Forms.Button buttonPoprzedni;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxHistoria;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonResetHistoria;
        private System.Windows.Forms.Button buttonLosowo;
        private System.Windows.Forms.TabPage tabPageOdtwarzanie;
        private System.Windows.Forms.TabPage tabPageHistoria;
        private System.Windows.Forms.TabPage tabPagePlaylista;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odtwórzPlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zSystemuPlikówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajDoPlaylistyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zURLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zSystemuPlikówToolStripMenuItem1;
        public System.Windows.Forms.Button buttonStart;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelName;
        private System.Windows.Forms.Button buttonRewind;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelPlaylista;
        public System.Windows.Forms.TabControl tabControlOdtwarzanie;
        private System.Windows.Forms.Label labelPlaylistRemaining;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEditPlaylist;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDuration;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAlbum;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ListBox listBoxPlaylista;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenre;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TabControl tabControlSong;
        private System.Windows.Forms.TabPage tabPageImage;
        private System.Windows.Forms.TabPage tabPageWaveform;
        private NAudio.Gui.WaveViewer waveViewer1;
        private System.Windows.Forms.TabPage tabPageSpectrogram;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonSpectrogram;
    }
}

