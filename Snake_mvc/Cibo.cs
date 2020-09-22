using System;
using System.Drawing;

namespace Snake_mvc
{
    // classe astratta dell'oggetto cibo
    abstract class Cibo
    {
        private CampoGioco _campoGioco;
        private Pezzo _pezzoDiCibo = new Pezzo();

        // incapsulamento per accedere alle proprietà di lettura
        public Pezzo PezzoDiCibo
        {
            get { return _pezzoDiCibo; }
        }
        
        // costruttore
        public Cibo(CampoGioco view)
        {
            _campoGioco = view;
        }

        // metodo per generare il cibo
        public void GeneraCibo()
        {
            // variabili che rappresentano la grandezza massima della picturebox
            int maxXpb = _campoGioco.PbCampoGioco.Size.Width / Impostazioni.Larghezza;
            int maxYpb = _campoGioco.PbCampoGioco.Size.Height / Impostazioni.Altezza;

            // funzione random per posiziobare il cibo nel campo da gioco
            Random random = new Random();
            _pezzoDiCibo = new Pezzo();
            _pezzoDiCibo.X = random.Next(0, maxXpb);
            _pezzoDiCibo.Y = random.Next(0, maxYpb);
        }

        // metodo virtuale per disegnare il cibo
        public virtual void DisegnaCibo(Graphics gioco)
        {
        }  
        
    }
}
