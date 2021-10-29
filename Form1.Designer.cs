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
            this.panelOdtwarzania = new System.Windows.Forms.Panel();
            this.buttonLosowo = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPetla = new System.Windows.Forms.Button();
            this.buttonNastepny = new System.Windows.Forms.Button();
            this.buttonPoprzedni = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonSyncAsync = new System.Windows.Forms.Button();
            this.buttonHistoria = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonOdtworz = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.listBoxPlaylista = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHistoria = new System.Windows.Forms.Panel();
            this.buttonResetHistoria = new System.Windows.Forms.Button();
            this.listBoxHistoria = new System.Windows.Forms.ListBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.panelOdtworz = new System.Windows.Forms.Panel();
            this.buttonSystem = new System.Windows.Forms.Button();
            this.buttonUrl = new System.Windows.Forms.Button();
            this.buttonFileDialog = new System.Windows.Forms.Button();
            this.panelSystem = new System.Windows.Forms.Panel();
            this.listBoxPliki = new System.Windows.Forms.ListBox();
            this.listBoxFoldery = new System.Windows.Forms.ListBox();
            this.panelUrl = new System.Windows.Forms.Panel();
            this.buttonWyszukaj = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.panelOdtwarzania.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelHistoria.SuspendLayout();
            this.panelOdtworz.SuspendLayout();
            this.panelSystem.SuspendLayout();
            this.panelUrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOdtwarzania
            // 
            this.panelOdtwarzania.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelOdtwarzania.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            // buttonLosowo
            // 
            this.buttonLosowo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLosowo.Location = new System.Drawing.Point(36, 13);
            this.buttonLosowo.Name = "buttonLosowo";
            this.buttonLosowo.Size = new System.Drawing.Size(52, 34);
            this.buttonLosowo.TabIndex = 6;
            this.buttonLosowo.Text = "Losowo";
            this.buttonLosowo.UseVisualStyleBackColor = false;
            this.buttonLosowo.Click += new System.EventHandler(this.ButtonLosowo_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonStop.Location = new System.Drawing.Point(284, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(46, 43);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // buttonPetla
            // 
            this.buttonPetla.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPetla.Location = new System.Drawing.Point(484, 13);
            this.buttonPetla.Name = "buttonPetla";
            this.buttonPetla.Size = new System.Drawing.Size(43, 33);
            this.buttonPetla.TabIndex = 4;
            this.buttonPetla.Text = "Pętla";
            this.buttonPetla.UseVisualStyleBackColor = false;
            this.buttonPetla.Click += new System.EventHandler(this.ButtonPetla_Click);
            // 
            // buttonNastepny
            // 
            this.buttonNastepny.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNastepny.Location = new System.Drawing.Point(336, 13);
            this.buttonNastepny.Name = "buttonNastepny";
            this.buttonNastepny.Size = new System.Drawing.Size(65, 33);
            this.buttonNastepny.TabIndex = 3;
            this.buttonNastepny.Text = "Następny";
            this.buttonNastepny.UseVisualStyleBackColor = false;
            this.buttonNastepny.Click += new System.EventHandler(this.ButtonNastepny_Click);
            // 
            // buttonPoprzedni
            // 
            this.buttonPoprzedni.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPoprzedni.Location = new System.Drawing.Point(160, 13);
            this.buttonPoprzedni.Name = "buttonPoprzedni";
            this.buttonPoprzedni.Size = new System.Drawing.Size(64, 33);
            this.buttonPoprzedni.TabIndex = 2;
            this.buttonPoprzedni.Text = "Poprzedni";
            this.buttonPoprzedni.UseVisualStyleBackColor = false;
            this.buttonPoprzedni.Click += new System.EventHandler(this.ButtonPoprzedni_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonStart.Location = new System.Drawing.Point(229, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(49, 43);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonSyncAsync);
            this.panelMenu.Controls.Add(this.buttonHistoria);
            this.panelMenu.Controls.Add(this.buttonDodaj);
            this.panelMenu.Controls.Add(this.buttonOdtworz);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Location = new System.Drawing.Point(12, 55);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(144, 141);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Visible = false;
            // 
            // buttonSyncAsync
            // 
            this.buttonSyncAsync.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSyncAsync.Location = new System.Drawing.Point(4, 92);
            this.buttonSyncAsync.Name = "buttonSyncAsync";
            this.buttonSyncAsync.Size = new System.Drawing.Size(137, 23);
            this.buttonSyncAsync.TabIndex = 4;
            this.buttonSyncAsync.Text = "Odtwórz synchronicznie";
            this.buttonSyncAsync.UseVisualStyleBackColor = false;
            this.buttonSyncAsync.Click += new System.EventHandler(this.ButtonSyncAsync_Click);
            // 
            // buttonHistoria
            // 
            this.buttonHistoria.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHistoria.Location = new System.Drawing.Point(4, 62);
            this.buttonHistoria.Name = "buttonHistoria";
            this.buttonHistoria.Size = new System.Drawing.Size(137, 23);
            this.buttonHistoria.TabIndex = 3;
            this.buttonHistoria.Text = "Historia odtworzeń";
            this.buttonHistoria.UseVisualStyleBackColor = false;
            this.buttonHistoria.Click += new System.EventHandler(this.ButtonHistoria_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDodaj.Location = new System.Drawing.Point(3, 32);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(138, 23);
            this.buttonDodaj.TabIndex = 2;
            this.buttonDodaj.Text = "Dodaj do playlisty";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.ButtonPlaylista_Click);
            // 
            // buttonOdtworz
            // 
            this.buttonOdtworz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonOdtworz.Location = new System.Drawing.Point(3, 3);
            this.buttonOdtworz.Name = "buttonOdtworz";
            this.buttonOdtworz.Size = new System.Drawing.Size(138, 23);
            this.buttonOdtworz.TabIndex = 1;
            this.buttonOdtworz.Text = "Odtwórz plik";
            this.buttonOdtworz.UseVisualStyleBackColor = false;
            this.buttonOdtworz.Click += new System.EventHandler(this.ButtonOdtworz_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.SystemColors.Info;
            this.buttonMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(50, 37);
            this.buttonMenu.TabIndex = 0;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // listBoxPlaylista
            // 
            this.listBoxPlaylista.AllowDrop = true;
            this.listBoxPlaylista.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBoxPlaylista.ForeColor = System.Drawing.SystemColors.Menu;
            this.listBoxPlaylista.FormattingEnabled = true;
            this.listBoxPlaylista.HorizontalScrollbar = true;
            this.listBoxPlaylista.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxPlaylista.Location = new System.Drawing.Point(38, 58);
            this.listBoxPlaylista.Name = "listBoxPlaylista";
            this.listBoxPlaylista.Size = new System.Drawing.Size(492, 329);
            this.listBoxPlaylista.TabIndex = 1;
            this.listBoxPlaylista.SelectedIndexChanged += new System.EventHandler(this.ListBoxPlaylista_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(573, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(558, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Wav Files Only (*.wav)|*.wav";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // panelHistoria
            // 
            this.panelHistoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHistoria.Controls.Add(this.buttonResetHistoria);
            this.panelHistoria.Controls.Add(this.listBoxHistoria);
            this.panelHistoria.Location = new System.Drawing.Point(159, 117);
            this.panelHistoria.Name = "panelHistoria";
            this.panelHistoria.Size = new System.Drawing.Size(370, 285);
            this.panelHistoria.TabIndex = 5;
            this.panelHistoria.Visible = false;
            // 
            // buttonResetHistoria
            // 
            this.buttonResetHistoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonResetHistoria.Location = new System.Drawing.Point(271, 260);
            this.buttonResetHistoria.Name = "buttonResetHistoria";
            this.buttonResetHistoria.Size = new System.Drawing.Size(99, 23);
            this.buttonResetHistoria.TabIndex = 1;
            this.buttonResetHistoria.Text = "Wyczyść historię";
            this.buttonResetHistoria.UseVisualStyleBackColor = false;
            this.buttonResetHistoria.Click += new System.EventHandler(this.ButtonResetHistoria_Click);
            // 
            // listBoxHistoria
            // 
            this.listBoxHistoria.FormattingEnabled = true;
            this.listBoxHistoria.Location = new System.Drawing.Point(3, 3);
            this.listBoxHistoria.Name = "listBoxHistoria";
            this.listBoxHistoria.Size = new System.Drawing.Size(364, 251);
            this.listBoxHistoria.TabIndex = 0;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonReset.Location = new System.Drawing.Point(428, 393);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(101, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Wyczyść playlistę";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUsun.Location = new System.Drawing.Point(338, 393);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(83, 23);
            this.buttonUsun.TabIndex = 7;
            this.buttonUsun.Text = "Usuń wybrane";
            this.buttonUsun.UseVisualStyleBackColor = false;
            this.buttonUsun.Click += new System.EventHandler(this.ButtonUsun_Click);
            // 
            // panelOdtworz
            // 
            this.panelOdtworz.Controls.Add(this.buttonSystem);
            this.panelOdtworz.Controls.Add(this.buttonUrl);
            this.panelOdtworz.Controls.Add(this.buttonFileDialog);
            this.panelOdtworz.Location = new System.Drawing.Point(159, 55);
            this.panelOdtworz.Name = "panelOdtworz";
            this.panelOdtworz.Size = new System.Drawing.Size(108, 85);
            this.panelOdtworz.TabIndex = 8;
            this.panelOdtworz.Visible = false;
            // 
            // buttonSystem
            // 
            this.buttonSystem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSystem.Location = new System.Drawing.Point(4, 60);
            this.buttonSystem.Name = "buttonSystem";
            this.buttonSystem.Size = new System.Drawing.Size(97, 23);
            this.buttonSystem.TabIndex = 2;
            this.buttonSystem.Text = "Z systemu plików";
            this.buttonSystem.UseVisualStyleBackColor = false;
            this.buttonSystem.Click += new System.EventHandler(this.ButtonSystem_Click);
            // 
            // buttonUrl
            // 
            this.buttonUrl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUrl.Location = new System.Drawing.Point(4, 31);
            this.buttonUrl.Name = "buttonUrl";
            this.buttonUrl.Size = new System.Drawing.Size(97, 23);
            this.buttonUrl.TabIndex = 1;
            this.buttonUrl.Text = "Z url";
            this.buttonUrl.UseVisualStyleBackColor = false;
            this.buttonUrl.Click += new System.EventHandler(this.ButtonUrl_Click);
            // 
            // buttonFileDialog
            // 
            this.buttonFileDialog.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFileDialog.Location = new System.Drawing.Point(4, 2);
            this.buttonFileDialog.Name = "buttonFileDialog";
            this.buttonFileDialog.Size = new System.Drawing.Size(97, 23);
            this.buttonFileDialog.TabIndex = 0;
            this.buttonFileDialog.Text = "OpenFileDialog";
            this.buttonFileDialog.UseVisualStyleBackColor = false;
            this.buttonFileDialog.Click += new System.EventHandler(this.ButtonFileDialog_Click);
            // 
            // panelSystem
            // 
            this.panelSystem.Controls.Add(this.listBoxPliki);
            this.panelSystem.Controls.Add(this.listBoxFoldery);
            this.panelSystem.Location = new System.Drawing.Point(159, 140);
            this.panelSystem.Name = "panelSystem";
            this.panelSystem.Size = new System.Drawing.Size(393, 208);
            this.panelSystem.TabIndex = 9;
            this.panelSystem.Visible = false;
            // 
            // listBoxPliki
            // 
            this.listBoxPliki.FormattingEnabled = true;
            this.listBoxPliki.Location = new System.Drawing.Point(4, 105);
            this.listBoxPliki.Name = "listBoxPliki";
            this.listBoxPliki.Size = new System.Drawing.Size(386, 95);
            this.listBoxPliki.TabIndex = 2;
            this.listBoxPliki.SelectedIndexChanged += new System.EventHandler(this.ListBoxPliki_SelectedIndexChanged);
            // 
            // listBoxFoldery
            // 
            this.listBoxFoldery.FormattingEnabled = true;
            this.listBoxFoldery.Location = new System.Drawing.Point(3, 4);
            this.listBoxFoldery.Name = "listBoxFoldery";
            this.listBoxFoldery.Size = new System.Drawing.Size(386, 95);
            this.listBoxFoldery.TabIndex = 1;
            this.listBoxFoldery.SelectedIndexChanged += new System.EventHandler(this.ListBoxFoldery_SelectedIndexChanged);
            // 
            // panelUrl
            // 
            this.panelUrl.Controls.Add(this.buttonWyszukaj);
            this.panelUrl.Controls.Add(this.textBoxUrl);
            this.panelUrl.Location = new System.Drawing.Point(266, 87);
            this.panelUrl.Name = "panelUrl";
            this.panelUrl.Size = new System.Drawing.Size(200, 53);
            this.panelUrl.TabIndex = 10;
            this.panelUrl.Visible = false;
            // 
            // buttonWyszukaj
            // 
            this.buttonWyszukaj.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonWyszukaj.Location = new System.Drawing.Point(122, 28);
            this.buttonWyszukaj.Name = "buttonWyszukaj";
            this.buttonWyszukaj.Size = new System.Drawing.Size(75, 23);
            this.buttonWyszukaj.TabIndex = 1;
            this.buttonWyszukaj.Text = "Wyszukaj";
            this.buttonWyszukaj.UseVisualStyleBackColor = false;
            this.buttonWyszukaj.Click += new System.EventHandler(this.ButtonWyszukaj_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(3, 4);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(194, 20);
            this.textBoxUrl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(573, 501);
            this.Controls.Add(this.panelHistoria);
            this.Controls.Add(this.panelUrl);
            this.Controls.Add(this.panelOdtworz);
            this.Controls.Add(this.panelSystem);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.listBoxPlaylista);
            this.Controls.Add(this.panelOdtwarzania);
            this.Controls.Add(this.buttonMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Audio Player";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.panelOdtwarzania.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelHistoria.ResumeLayout(false);
            this.panelOdtworz.ResumeLayout(false);
            this.panelSystem.ResumeLayout(false);
            this.panelUrl.ResumeLayout(false);
            this.panelUrl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelOdtwarzania;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonOdtworz;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonPetla;
        private System.Windows.Forms.Button buttonNastepny;
        private System.Windows.Forms.Button buttonPoprzedni;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListBox listBoxPlaylista;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonHistoria;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonSyncAsync;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelHistoria;
        private System.Windows.Forms.ListBox listBoxHistoria;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonResetHistoria;
        private System.Windows.Forms.Panel panelOdtworz;
        private System.Windows.Forms.Button buttonSystem;
        private System.Windows.Forms.Button buttonUrl;
        private System.Windows.Forms.Button buttonFileDialog;
        private System.Windows.Forms.Panel panelSystem;
        private System.Windows.Forms.ListBox listBoxPliki;
        private System.Windows.Forms.ListBox listBoxFoldery;
        private System.Windows.Forms.Panel panelUrl;
        private System.Windows.Forms.Button buttonWyszukaj;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Button buttonLosowo;
    }
}

