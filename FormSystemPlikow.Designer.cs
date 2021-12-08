namespace AudioPlayerSerwatko
{
    partial class FormSystemPlikow
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
            this.listBoxPliki = new System.Windows.Forms.ListBox();
            this.listBoxFoldery = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonWroc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPliki
            // 
            this.listBoxPliki.FormattingEnabled = true;
            this.listBoxPliki.Location = new System.Drawing.Point(12, 144);
            this.listBoxPliki.Name = "listBoxPliki";
            this.listBoxPliki.Size = new System.Drawing.Size(386, 95);
            this.listBoxPliki.TabIndex = 2;
            this.listBoxPliki.SelectedIndexChanged += new System.EventHandler(this.listBoxPliki_SelectedIndexChanged);
            // 
            // listBoxFoldery
            // 
            this.listBoxFoldery.FormattingEnabled = true;
            this.listBoxFoldery.Location = new System.Drawing.Point(12, 43);
            this.listBoxFoldery.Name = "listBoxFoldery";
            this.listBoxFoldery.Size = new System.Drawing.Size(386, 95);
            this.listBoxFoldery.TabIndex = 1;
            this.listBoxFoldery.SelectedIndexChanged += new System.EventHandler(this.listBoxFoldery_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz plik z systemu plików";
            // 
            // buttonWroc
            // 
            this.buttonWroc.Location = new System.Drawing.Point(12, 14);
            this.buttonWroc.Name = "buttonWroc";
            this.buttonWroc.Size = new System.Drawing.Size(75, 23);
            this.buttonWroc.TabIndex = 4;
            this.buttonWroc.Text = "Wróć";
            this.buttonWroc.UseVisualStyleBackColor = true;
            this.buttonWroc.Click += new System.EventHandler(this.buttonWroc_Click);
            // 
            // FormSystemPlikow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 255);
            this.Controls.Add(this.buttonWroc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPliki);
            this.Controls.Add(this.listBoxFoldery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSystemPlikow";
            this.Text = "Z systemu plików";
            this.Load += new System.EventHandler(this.FormSystemPlikow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPliki;
        private System.Windows.Forms.ListBox listBoxFoldery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonWroc;
    }
}