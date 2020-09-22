using System;
using System.Windows.Forms;

namespace Snake_mvc
{
    public partial class CampoGioco : Form
    {
        // istanze
        private PictureBox _pbCampoGioco;
        private Partita _partitaCorrente;
        private Label _lblPunteggio;

        // proprietà di incapsulamento per accedere alle proprietà di lettura di _pbCampoGioco
        public PictureBox PbCampoGioco
        {
            get { return _pbCampoGioco; }
        }
        // proprietà di incapsulamento per accedere alle proprietà di lettura di _lblPunteggio
        public Label LblPunteggio
        {
            get { return _lblPunteggio; }
        }
        // costruttore
        public CampoGioco()
        {
            InitializeComponent();
            _lblPunteggio = lblPunteggio;
            _pbCampoGioco = pbGioco;

            // eventi key del form
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;

            // imposta le impostazioni di default
            new Impostazioni();

            _partitaCorrente = new Partita(this);
            _partitaCorrente.IniziaPartita();
            pbGioco.Paint += _partitaCorrente.DisegnaForm;

            // imposta la velocità e il timer(start)
            timerGioco.Interval = 1000 / Impostazioni.Velocità;
            timerGioco.Tick += _partitaCorrente.AggiornaSchermo;
            timerGioco.Start();
        }
        // se un tasto è premuto allora SetTasto = true
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Controller.SetTasto(e.KeyCode, true);
        }
        // se un tasto viene rilasciato allora SetTasto = false
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Controller.SetTasto(e.KeyCode, false);
        }
        // evento click di btnRigioca
        private void btnRigioca_Click(object sender, EventArgs e)
        {
            _partitaCorrente.IniziaPartita(); // inizia nuova partita
        }
        // evento click di btnEsci
        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close(); // chiudi
        }
    }
}

