namespace AudioPlayerSerwatko
{
    partial class FormURL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonWyszukaj = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonWyszukaj
            // 
            this.buttonWyszukaj.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonWyszukaj.Location = new System.Drawing.Point(131, 61);
            this.buttonWyszukaj.Name = "buttonWyszukaj";
            this.buttonWyszukaj.Size = new System.Drawing.Size(75, 23);
            this.buttonWyszukaj.TabIndex = 1;
            this.buttonWyszukaj.Text = "Wyszukaj";
            this.buttonWyszukaj.UseVisualStyleBackColor = false;
            this.buttonWyszukaj.Click += new System.EventHandler(this.buttonWyszukaj_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(12, 35);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(194, 20);
            this.textBoxUrl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wpisz adres URL";
            // 
            // FormURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 98);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonWyszukaj);
            this.Controls.Add(this.textBoxUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormURL";
            this.Text = "Z adresu URL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWyszukaj;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label1;
    }
}