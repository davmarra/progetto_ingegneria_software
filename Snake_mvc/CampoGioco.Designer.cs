namespace Snake_mvc
{
    partial class CampoGioco
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbGioco = new System.Windows.Forms.PictureBox();
            this.lblGrafica = new System.Windows.Forms.Label();
            this.lblPunteggio = new System.Windows.Forms.Label();
            this.lblFineGioco = new System.Windows.Forms.Label();
            this.timerGioco = new System.Windows.Forms.Timer(this.components);
            this.btnRigioca = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGioco)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGioco
            // 
            this.pbGioco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pbGioco.Location = new System.Drawing.Point(5, 5);
            this.pbGioco.Name = "pbGioco";
            this.pbGioco.Size = new System.Drawing.Size(600, 450);
            this.pbGioco.TabIndex = 0;
            this.pbGioco.TabStop = false;
            // 
            // lblGrafica
            // 
            this.lblGrafica.AutoSize = true;
            this.lblGrafica.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrafica.ForeColor = System.Drawing.Color.Lime;
            this.lblGrafica.Location = new System.Drawing.Point(12, 466);
            this.lblGrafica.Name = "lblGrafica";
            this.lblGrafica.Size = new System.Drawing.Size(181, 32);
            this.lblGrafica.TabIndex = 1;
            this.lblGrafica.Text = "Punteggio :";
            // 
            // lblPunteggio
            // 
            this.lblPunteggio.AutoSize = true;
            this.lblPunteggio.Font = new System.Drawing.Font("Magneto", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunteggio.ForeColor = System.Drawing.Color.Lime;
            this.lblPunteggio.Location = new System.Drawing.Point(199, 466);
            this.lblPunteggio.Name = "lblPunteggio";
            this.lblPunteggio.Size = new System.Drawing.Size(98, 32);
            this.lblPunteggio.TabIndex = 2;
            this.lblPunteggio.Text = "label1";
            // 
            // lblFineGioco
            // 
            this.lblFineGioco.AutoSize = true;
            this.lblFineGioco.BackColor = System.Drawing.Color.Lime;
            this.lblFineGioco.Font = new System.Drawing.Font("Ravie", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineGioco.Location = new System.Drawing.Point(62, 112);
            this.lblFineGioco.Name = "lblFineGioco";
            this.lblFineGioco.Size = new System.Drawing.Size(114, 34);
            this.lblFineGioco.TabIndex = 3;
            this.lblFineGioco.Text = "Snake";
            // 
            // btnRigioca
            // 
            this.btnRigioca.BackColor = System.Drawing.Color.Gray;
            this.btnRigioca.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRigioca.ForeColor = System.Drawing.Color.Lime;
            this.btnRigioca.Location = new System.Drawing.Point(268, 223);
            this.btnRigioca.Name = "btnRigioca";
            this.btnRigioca.Size = new System.Drawing.Size(89, 31);
            this.btnRigioca.TabIndex = 4;
            this.btnRigioca.Text = "Rigioca";
            this.btnRigioca.UseVisualStyleBackColor = false;
            this.btnRigioca.Visible = false;
            this.btnRigioca.Click += new System.EventHandler(this.btnRigioca_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.BackColor = System.Drawing.Color.Gray;
            this.btnEsci.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsci.ForeColor = System.Drawing.Color.Lime;
            this.btnEsci.Location = new System.Drawing.Point(268, 260);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(89, 30);
            this.btnEsci.TabIndex = 5;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = false;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // CampoGioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(610, 511);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.btnRigioca);
            this.Controls.Add(this.lblFineGioco);
            this.Controls.Add(this.lblPunteggio);
            this.Controls.Add(this.lblGrafica);
            this.Controls.Add(this.pbGioco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CampoGioco";
            this.Text = "Snake";
            ((System.ComponentModel.ISupportInitialize)(this.pbGioco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGrafica;
        private System.Windows.Forms.Timer timerGioco;
        public System.Windows.Forms.Label lblFineGioco;
        public System.Windows.Forms.Button btnRigioca;
        public System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.PictureBox pbGioco;
        public System.Windows.Forms.Label lblPunteggio;
    }
}

