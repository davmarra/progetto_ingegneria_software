using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_mvc
{
    class Partita
    {
        private CampoGioco _campoGioco;
        private Snake _snake;
        private Cibo _cibo;

        public Partita(CampoGioco campoGioco)
        {
            _campoGioco = campoGioco;
        }

        // metodo per generare casualmente gli oggetti cibo
        public void GeneraNuovoCibo()
        {
            Random sceltaCibo = new Random();
            if (sceltaCibo.NextDouble() >=0.3)
            {
                _cibo = new CiboGiallo(_campoGioco); // se la la funzione random restituisce un double da 0.31 a 1.0 genera un oggetto CiboGiallo
            }
            else
            {
                _cibo = new CiboRosso(_campoGioco); // se la la funzione random restituisce un double da 0.01 a 0.3 genera un oggetto CiboRosso
            }

            _cibo.GeneraCibo();  // richiamo al metodo GeneraCibo
        }
        // incapsulamento 
        public Cibo _Cibo
        {
            get { return _cibo; }
        }

        public void IniziaPartita()
        {
            // nascondi la label e i 2 button
            _campoGioco.lblFineGioco.Visible = false;
            _campoGioco.btnRigioca.Visible = false;
            _campoGioco.btnRigioca.Enabled = false;
            _campoGioco.btnEsci.Visible = false;
            _campoGioco.btnEsci.Enabled = false;

            // imposta le impostazioni di default
            new Impostazioni();

            // crea un nuovo oggetto giocatore
            if(_snake != null)
                _snake._PezziDelSerpente.Clear();

            _snake = new Snake(_campoGioco, this);
            _snake.CreaSnake();

            // crea un nuovo oggetto cibo
            GeneraNuovoCibo();
            // associa alla label punteggio l'attrubuto punteggio
            _campoGioco.lblPunteggio.Text = Impostazioni.Punteggio.ToString();
        }


        // richiamato ad ogni tick del timer
        public void AggiornaSchermo(object sender, EventArgs e)
        {
            // controllo morte
            if (Impostazioni.Morte)
            {

            }
            else
            {
                // Controllo per non far muovere snake sopra se stesso
                if (Controller.TastoPremuto(Keys.Right) && Impostazioni.direzione != Direzione.Sinistra)
                    Impostazioni.direzione = Direzione.Destra;
                else if (Controller.TastoPremuto(Keys.Left) && Impostazioni.direzione != Direzione.Destra)
                    Impostazioni.direzione = Direzione.Sinistra;
                else if (Controller.TastoPremuto(Keys.Up) && Impostazioni.direzione != Direzione.Sotto)
                    Impostazioni.direzione = Direzione.Sopra;
                else if (Controller.TastoPremuto(Keys.Down) && Impostazioni.direzione != Direzione.Sopra)
                    Impostazioni.direzione = Direzione.Sotto;

                _snake.MuoviGiocatore();
            }
            // Blocca la picturebox di gioco
            _campoGioco.PbCampoGioco.Invalidate();
        }

        // metodo per disegnare
        public void DisegnaForm(object sender, PaintEventArgs e)
        {
            Graphics gioco = e.Graphics;

            if (!Impostazioni.Morte)
            {
                // imposta il colore di snake
                Brush coloreSnake;

                // disegna snake
                for (int i = 0; i < _snake._PezziDelSerpente.Count; i++)
                {
                    if (i == 0)
                        coloreSnake = Brushes.LimeGreen; // colora la testa di snake
                    else
                        coloreSnake = Brushes.Chartreuse; // colora il corpo di snake

                    // richiamo al metodo disegna snake (classe Snake)
                    _snake.DisegnaPezzoSnake(gioco, i, coloreSnake);

                    // richiamo al metodo disegna cibo (classe cibo)
                    _cibo.DisegnaCibo(gioco);
                }                        
            }
      
            else
            {
                // associamo alla stringa morte il punteggio e la lunghezza di snake
                string morte = ("Gioco Finito! \nPunteggio Finale: " + Impostazioni.Punteggio +"\nSnake di lunghezza: "+ _snake._PezziDelSerpente.Count);
                // rendiamo visibili la label e i 2 button
                _campoGioco.lblFineGioco.Text = morte;
                _campoGioco.lblFineGioco.Visible = true;
                _campoGioco.btnRigioca.Visible = true;
                _campoGioco.btnRigioca.Enabled = true;
                _campoGioco.btnEsci.Visible = true;
                _campoGioco.btnEsci.Enabled = true;
                

            }
        }
    }
}
