using System.Collections.Generic;
using System.Drawing;

namespace Snake_mvc
{
    class Snake
    {
        private List<Pezzo> _pezziDelSerpente = new List<Pezzo>();
        private CampoGioco _campoGioco;
        private Partita _partita;

        // proprietà di incapsulamento per accedere alle proprietà di lettura della lista _pezziDelSerpente
        public List<Pezzo> _PezziDelSerpente
        {
            get { return _pezziDelSerpente; }
        }

        // costruttore
        public Snake(CampoGioco campoGioco, Partita partita)
        {
            _campoGioco = campoGioco;
            _partita = partita;
        }

        // metodo per creare la testa di snake
        public void CreaSnake()
        {
            Pezzo testa = new Pezzo();
            testa.X = 20;  // cordinata x della creazione della testa
            testa.Y = 1;  // cordinata y della creazione della testa
            _pezziDelSerpente.Add(testa);
        }

        // metodo muori
        public void Muori()
        {
            // imposta a true la variabile booleana morte
            Impostazioni.Morte = true;
        }

        // metodo mangia
        public void Mangia()
        {
            // aggiungi un rettangolo al corpo
            Pezzo rettangolo = new Pezzo
            {
                X = _pezziDelSerpente[_pezziDelSerpente.Count - 1].X,
                Y = _pezziDelSerpente[_pezziDelSerpente.Count - 1].Y
            };
            _pezziDelSerpente.Add(rettangolo);

            // aggiorna punteggio sommandogli i punti
            Impostazioni.Punteggio += Impostazioni.Punti;
            _campoGioco.LblPunteggio.Text = Impostazioni.Punteggio.ToString();

            // genera un nuovo oggetto cibo dopo che è stato mangiato
            _partita.GeneraNuovoCibo();
        }

        // Metodo per disegnare snake
        public void DisegnaPezzoSnake(Graphics gioco, int i, Brush coloreSnake)
        {
            gioco.FillRectangle(coloreSnake,
                        new Rectangle(_pezziDelSerpente[i].X * Impostazioni.Larghezza,
                                       _pezziDelSerpente[i].Y * Impostazioni.Altezza,
                                      Impostazioni.Larghezza, Impostazioni.Altezza));
        }

        // Metodo movimento (comprende le collisioni con il bordo e con il cibo)
        public void MuoviGiocatore()
        {
            for (int i = _pezziDelSerpente.Count - 1; i >= 0; i--)
            {
                // muovi la testa
                if (i == 0)
                {
                    switch (Impostazioni.direzione)
                    {
                        case Direzione.Destra:
                            _pezziDelSerpente[i].X++;
                            break;
                        case Direzione.Sinistra:
                            _pezziDelSerpente[i].X--;
                            break;
                        case Direzione.Sopra:
                            _pezziDelSerpente[i].Y--;
                            break;
                        case Direzione.Sotto:
                            _pezziDelSerpente[i].Y++;
                            break;
                    }

                    // ottieni x e y massimi della picturebox
                    int maxXpb = _campoGioco.PbCampoGioco.Size.Width / Impostazioni.Larghezza;
                    int maxYpb = _campoGioco.PbCampoGioco.Size.Height / Impostazioni.Altezza;

                    // rileva collisioni con i bordi del gioco(Picturebox)
                    if (_pezziDelSerpente[i].X < 0 || _pezziDelSerpente[i].Y < 0
                        || _pezziDelSerpente[i].X >= maxXpb || _pezziDelSerpente[i].Y >= maxYpb)
                    {
                        Muori();
                    }

                    // rileva collisioni con il corpo
                    for (int j = 1; j < _pezziDelSerpente.Count; j++)
                    {
                        if (_pezziDelSerpente[i].X == _pezziDelSerpente[j].X &&
                            _pezziDelSerpente[i].Y == _pezziDelSerpente[j].Y)
                        {
                            Muori();
                        }
                    }
                    // rileva collisioni con il cibo
                    if (_pezziDelSerpente[0].X == _partita._Cibo.PezzoDiCibo.X &&
                        _pezziDelSerpente[0].Y == _partita._Cibo.PezzoDiCibo.Y)
                    {
                        Mangia();
                    }
                }
                else
                {
                    // muovi il corpo
                    _pezziDelSerpente[i].X = _pezziDelSerpente[i - 1].X;
                    _pezziDelSerpente[i].Y = _pezziDelSerpente[i - 1].Y;
                }
            }
        }
    }
}
