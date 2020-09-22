namespace Snake_mvc
{
    partial class Inizio
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
            this.btnGioca = new System.Windows.Forms.Button();
            this.btnIstruzioni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEsci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGioca
            // 
            this.btnGioca.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGioca.Font = new System.Drawing.Font("Old English Text MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioca.ForeColor = System.Drawing.Color.Lime;
            this.btnGioca.Location = new System.Drawing.Point(9, 245);
            this.btnGioca.Name = "btnGioca";
            this.btnGioca.Size = new System.Drawing.Size(106, 33);
            this.btnGioca.TabIndex = 0;
            this.btnGioca.Text = "Gioca";
            this.btnGioca.UseVisualStyleBackColor = false;
            this.btnGioca.Click += new System.EventHandler(this.btnGioca_Click);
            // 
            // btnIstruzioni
            // 
            this.btnIstruzioni.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnIstruzioni.Font = new System.Drawing.Font("Old English Text MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIstruzioni.ForeColor = System.Drawing.Color.Lime;
            this.btnIstruzioni.Location = new System.Drawing.Point(9, 206);
            this.btnIstruzioni.Name = "btnIstruzioni";
            this.btnIstruzioni.Size = new System.Drawing.Size(106, 33);
            this.btnIstruzioni.TabIndex = 1;
            this.btnIstruzioni.Text = "Istruzioni";
            this.btnIstruzioni.UseVisualStyleBackColor = false;
            this.btnIstruzioni.Click += new System.EventHandler(this.btnIstruzioni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Ravie", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Snake";
            // 
            // btnEsci
            // 
            this.btnEsci.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEsci.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsci.ForeColor = System.Drawing.Color.Lime;
            this.btnEsci.Location = new System.Drawing.Point(9, 284);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(106, 33);
            this.btnEsci.TabIndex = 3;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = false;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // Inizio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake_mvc.Properties.Resources.Snake_rev_625x625;
            this.ClientSize = new System.Drawing.Size(609, 604);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIstruzioni);
            this.Controls.Add(this.btnGioca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inizio";
            this.Text = "Inizio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGioca;
        private System.Windows.Forms.Button btnIstruzioni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEsci;
    }
}