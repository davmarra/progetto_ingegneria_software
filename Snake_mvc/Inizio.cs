using System;
using System.Windows.Forms;

namespace Snake_mvc
{
    public partial class Inizio : Form
    {
        public Inizio()
        {
            InitializeComponent();
        }

        // visualizza il form CampoGioco dove è possibile iniziare a giocare
        private void btnGioca_Click(object sender, EventArgs e)
        {
            Form campoGioco = new CampoGioco();
            campoGioco.Show();
        }

        // esce dal programma
        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // visualizza il form contenente le istruzioni del gioco
        private void btnIstruzioni_Click(object sender, EventArgs e)
        {
            Form Istruzioni = new Istruzioni();
            Istruzioni.Show();
        }
    }
}
